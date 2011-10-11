using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace YubikeyDecrypt
{
    public static class ModHex
    {
        private static char[] alphabet = new char[] { 'c', 'b', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'n', 'r', 't', 'u', 'v' };

        private static byte Value(char c)
        {
            switch (c)
            {
                default:
                case 'c': return 0x0;
                case 'b': return 0x1;
                case 'd': return 0x2;
                case 'e': return 0x3;
                case 'f': return 0x4;
                case 'g': return 0x5;
                case 'h': return 0x6;
                case 'i': return 0x7;
                case 'j': return 0x8;
                case 'k': return 0x9;
                case 'l': return 0xa;
                case 'n': return 0xb;
                case 'r': return 0xc;
                case 't': return 0xd;
                case 'u': return 0xe;
                case 'v': return 0xf;
            }
        }

        public static string Encode(byte[] data)
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < data.Length; ++i)
            {
                str.Append(alphabet[(data[i] >> 4) & 0xf]);
                str.Append(alphabet[data[i] & 0xf]);
            }

            return str.ToString();
        }

        public static byte[] Decode(string str)
        {
            Debug.Assert(str.Length % 2 == 0);
            byte[] data = new byte[str.Length / 2];
            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = (byte)(Value(str[i * 2]) << 4 | Value(str[i * 2 + 1]));
            }
            return data;
        }
    }
}
