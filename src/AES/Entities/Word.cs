using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AES.Entities
{
    public class Word
    {
        public Byte[] Value { get; }

        public Word(Byte[] bytes)
        {
            if (bytes == null || bytes.Length != 4)
                throw new ArgumentException("4 bytes expected to create a word");

            Value = bytes;
        }        

        public override string ToString()
        {
            return string.Join(" ", Value.Select(b => b.ToString()));
        }
    }
}
