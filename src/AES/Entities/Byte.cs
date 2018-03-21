using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AES.Entities
{
    public class Byte
    {
        public int Value { get; }

        public Byte(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException("Input string cannot be empty");

            this.Value = ParseHex(input);
        }

        public Byte(int input)
        {
            this.Value = input;
        }

        public override string ToString()
        {
            return Value < 16 ? string.Format("0{0:X}", Value) : string.Format("{0:X}", Value);
        }

        private int ParseHex(string input)
        {
            return int.Parse(input, NumberStyles.HexNumber);
        }
    }
}
