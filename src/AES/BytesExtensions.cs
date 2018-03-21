using System;
using System.Collections.Generic;
using System.Text;

namespace AES
{
    public static class BytesExtensions
    {
        public static Entities.Byte Xor(this Entities.Byte _byte, Entities.Byte other)
        {
            return new Entities.Byte(_byte.Value ^ other.Value);
        }
    }
}
