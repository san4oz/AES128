using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AES;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialKey = "20406000A0C0E10121416181A1C1E000";
            var key = new RoundKeyProvider().GenerateRoundKey(initialKey, 1);
            Console.Read();
        }
    }
}
