using AES.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES
{
    public static class StringExtensions
    {
        private const int ByteStringLength = 2;
        private const int WordStringLength = 8;

        public static List<Word> ExtractWords(this string plainText)
        {
            var words = new List<Word>();

            for(var i = 0; i < plainText.Length; i += WordStringLength)
            {
                var wordString = plainText.Substring(i, Math.Min(WordStringLength, plainText.Length - i));
                var bytes = new List<AES.Entities.Byte>();
                for(var j = 0; j < wordString.Length; j+= ByteStringLength)
                {
                    var byteString = wordString.Substring(j, Math.Min(ByteStringLength, wordString.Length - j));
                    var _byte = new AES.Entities.Byte(byteString);
                    bytes.Add(_byte);
                }

                words.Add(new Word(bytes.ToArray()));
            }

            return words;
        }
    }
}
