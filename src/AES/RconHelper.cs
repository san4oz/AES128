using AES.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AES
{
    public static class RconHelper
    {
        public static Word GetRconWord(int round)
        {
            var bytes = GetRconConstForRound(round)
                .Select(value => new Entities.Byte(value))
                .ToArray();

            return new Word(bytes);
        }

        private static IEnumerable<int> GetRconConstForRound(int round)
        {
            switch (round)
            {
                case 1:
                    return new int[] { 1, 0, 0, 0 };
                case 2:
                    return new int[] { 2, 0, 0, 0 };
                case 3:
                    return new int[] { 4, 0, 0, 0 };
                case 4:
                    return new int[] { 8, 0, 0, 0 };
                case 5:
                    return new int[] { 16, 0, 0, 0 };
                case 6:
                    return new int[] { 32, 0, 0, 0 };
                case 7:
                    return new int[] { 64, 0, 0, 0 };
                case 8:
                    return new int[] { 128, 0, 0, 0 };
                case 9:
                    return new int[] { 27, 0, 0, 0 };
                case 10:
                    return new int[] { 54, 0, 0, 0 };
                default:
                    throw new ArgumentException("Not supported round value");
            }
        }
    }
}
