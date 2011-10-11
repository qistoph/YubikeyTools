using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace YubikeyDecrypt
{
    public struct YubikeyToken
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] UID;
        public ushort Counter;
        public ushort TimestampLow;
        public byte TimestampHigh;
        public byte UseCount;
        public ushort Random;
        public ushort CRC;
    }


}
