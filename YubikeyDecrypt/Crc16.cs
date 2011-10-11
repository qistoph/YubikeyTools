using System;

namespace YubikeyDecrypt
{
    public static class Crc16
    {
        public static ushort ComputeChecksum(byte[] bytes)
        {
            return ComputeChecksum(bytes, 0, bytes.Length);
        }

        public static ushort ComputeChecksum(byte[] bytes, int offset, int length)
        {
            ushort crc = 0xffff;
            int i, j, c;

            int end = offset + length;
            if (end > bytes.Length) end = bytes.Length;

            for (c = offset; c < end; ++c)
            {
                crc ^= bytes[c];

                for (i = 0; i < 8; ++i)
                {
                    j = crc & 1;
                    crc >>= 1;
                    if (j == 1) crc ^= 0x8408;
                }
            }

            return crc;
        }
    }
}