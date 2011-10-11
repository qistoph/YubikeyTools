using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YubikeyDecrypt
{
    public static class Hex
    {
        public static byte[] Decode(string str)
        {
            byte[] data = new byte[str.Length / 2];
            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = (byte)(HexValue(str[i * 2]) << 4 | HexValue(str[i * 2 + 1]));
            }
            return data;
        }

        private static byte HexValue(char c)
        {
            if (c >= '0' && c <= '9') return (byte)(c - '0');
            if (c >= 'A' && c <= 'F') return (byte)(c - 'A' + 10);
            if (c >= 'a' && c <= 'f') return (byte)(c - 'a' + 10);
            return 0;
        }

        public static ushort DecodeToUshort(string str)
        {
            ushort value = 0;
            if (str.Length > 4)
            {
                throw new ArgumentException("too long", "str");
            }

            for (int i = 0; i < str.Length; ++i)
            {
                value <<= 4;
                value += HexValue(str[i]);
            }

            return value;
        }
    }
}
