using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace YubikeyDecrypt
{
    public partial class Form1 : Form
    {
        Regex regHex = new Regex("^[0-9a-f]+$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        Regex regModHex = new Regex("^[cbdefghijklnrtuv]+$", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public Form1()
        {
            InitializeComponent();
        }

        private void txtInputAesKey_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txtInputOtp_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            lblInputStatus.Text = "";
            txtOutputPid.Text = "";
            txtOutputHex.Text = "";
            txtOutputCrc.Text = "";
            txtOutputCrc.BackColor = SystemColors.Window;

            byte[] inputAesKey, inputOtp;
            string publicId;
            try
            {
                inputAesKey = GetByteArrayFromString(txtInputAesKey.Text);
            }
            catch (ArgumentException ex)
            {
                lblInputStatus.Text = "AES key: " + ex.Message;
                return;
            }

            try
            {
                string inputStr = txtInputOtp.Text;
                if (inputStr.Length < 32)
                    return;
                publicId = inputStr.Substring(0, inputStr.Length - 32);
                inputOtp = GetByteArrayFromString(inputStr.Substring(inputStr.Length - 32, 32));

                txtOutputPid.Text = publicId;
            }
            catch (ArgumentException ex)
            {
                lblInputStatus.Text = "OTP: " + ex.Message;
                return;
            }

            byte[] tokenData;
            try
            {
                tokenData = AesDecrypt(inputOtp, inputAesKey);
            }
            catch (CryptographicException ex)
            {
                lblInputStatus.Text = ex.Message;
                return;
            }

            txtOutputHex.Text = BitConverter.ToString(tokenData);

            ushort checksum = Crc16.ComputeChecksum(tokenData);
            if (checksum == 0xF0B8)
            {
                txtOutputCrc.Text = "OK";
                txtOutputCrc.BackColor = Color.LightGreen;
            }
            else
            {
                txtOutputCrc.Text = "Not OK";

                txtOutputCrc.BackColor = Color.LightPink;
            }

            YubikeyToken token = RawDeserialize<YubikeyToken>(tokenData, 0);
            txtOutputCrc.Text = string.Concat(token.CRC.ToString("X4"), " - ", txtOutputCrc.Text);
            txtOutputUid.Text = ModHex.Encode(token.UID);
            txtOutputUidHex.Text = BitConverter.ToString(token.UID);
            txtOutputSession.Text = token.Counter.ToString();
            txtOutputTimestampL.Text = token.TimestampLow.ToString();
            txtOutputTimestampH.Text = token.TimestampHigh.ToString();
            txtOutputTimestamp.Text = ((token.TimestampHigh << 16) | token.TimestampLow).ToString();
            txtOutputUseCount.Text = token.UseCount.ToString();
            txtOutputRandom.Text = token.Random.ToString("X4");
        }

        public static T RawDeserialize<T>(byte[] rawData, int position)
        {
            int rawsize = Marshal.SizeOf(typeof(T));
            if (rawsize > rawData.Length)
                throw new ArgumentException(string.Concat("Invalid rawData, size doesn't match. RawData is ", rawData.Length.ToString(), " bytes, expected ", rawsize.ToString()));

            IntPtr buffer = Marshal.AllocHGlobal(rawsize);
            Marshal.Copy(rawData, position, buffer, rawsize);
            T retobj = (T)Marshal.PtrToStructure(buffer, typeof(T));
            Marshal.FreeHGlobal(buffer);

            return retobj;
        }

        public static byte[] RawSerialize<T>(T obj)
        {
            int rawsize = Marshal.SizeOf(typeof(T));
            byte[] data = new byte[rawsize];

            IntPtr ptr = Marshal.AllocHGlobal(rawsize);
            Marshal.StructureToPtr(obj, ptr, false);
            Marshal.Copy(ptr, data, 0, rawsize);
            Marshal.FreeHGlobal(ptr);

            return data;
        }

        private byte[] AesEncrypt(byte[] data, byte[] aesKey)
        {
            return AesCrypt(data, aesKey, true);
        }

        private byte[] AesDecrypt(byte[] data, byte[] aesKey)
        {
            return AesCrypt(data, aesKey, false);
        }

        private byte[] AesCrypt(byte[] data, byte[] aesKey, bool encrypt)
        {
            Aes aes = Aes.Create();
            aes.Key = aesKey;
            aes.IV = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.None;
            ICryptoTransform crypter = encrypt ? aes.CreateEncryptor() : aes.CreateDecryptor();

            byte[] output = crypter.TransformFinalBlock(data, 0, data.Length);
            return output;
        }

        private byte[] GetByteArrayFromString(string str)
        {
            if (regHex.IsMatch(str))
            {
                return Hex.Decode(str);
            }
            else if (regModHex.IsMatch(str))
            {
                return ModHex.Decode(str);
            }

            throw new ArgumentException("Unknown data type.");
        }

        private void txtOutputField_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Focused)
            {
                GenerateOtp();
            }
        }

        private void GenerateOtp()
        {
            try
            {
                YubikeyToken token = new YubikeyToken();

                string pid = ModHex.Encode(ModHex.Decode(txtOutputPid.Text));
                token.UID = ModHex.Decode(txtOutputUid.Text);
                token.Counter = ushort.Parse(txtOutputSession.Text);
                token.TimestampLow = ushort.Parse(txtOutputTimestampL.Text);
                token.TimestampHigh = byte.Parse(txtOutputTimestampH.Text);
                token.UseCount = byte.Parse(txtOutputUseCount.Text);
                token.Random = Hex.DecodeToUshort(txtOutputRandom.Text);

                byte[] data = RawSerialize(token);
                token.CRC = (ushort)(~Crc16.ComputeChecksum(data, 0, 14));

                data = RawSerialize(token);

                data = AesEncrypt(data, Hex.Decode(txtInputAesKey.Text));

                txtInputOtp.Text = /*txtOtpGenerated.Text =*/ pid + ModHex.Encode(data);
            }
            catch (ArgumentException ex)
            {
                lblInputStatus.Text = ex.Message;
            }
            catch (FormatException ex)
            {
                lblInputStatus.Text = ex.Message;
            }
            catch (OverflowException ex)
            {
                lblInputStatus.Text = ex.Message;
            }
        }

        private void txtOutputTimestamp_TextChanged(object sender, EventArgs e)
        {
            int timestamp = int.Parse(txtOutputTimestamp.Text);
            ushort tstl = (ushort)(timestamp & 0xffff);
            byte tsth = (byte)(timestamp >> 16);

            txtOutputTimestampL.Text = tstl.ToString();
            txtOutputTimestampH.Text = tsth.ToString();
        }

    }
}
