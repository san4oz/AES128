using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AES.Entities;

namespace AES
{
    public static class WordsExtensions
    {
        public static Word Shift(this Word word)
        {
            var bytesArray = word.Value;

            AES.Entities.Byte[] resultArray = new AES.Entities.Byte[bytesArray.Length];
            for (int i = 0; i < bytesArray.Length; i++)
            {
                if (i < bytesArray.Length - 1)
                    resultArray[i] = bytesArray[i + 1];
                else
                    resultArray[i] = bytesArray[0];
            }

            return new Word(resultArray);
        }

        public static Word SubWord(this Word word)
        {
            var bytes = new List<Entities.Byte>();

            for(var i = 0; i < word.Value.Length; i++)
            {
                var replacedByte = new Entities.Byte(SBoxHelper.GetReplacement(word.Value[i].Value));
                bytes.Add(replacedByte);
            }

            return new Word(bytes.ToArray());
        }
       
        public static Word Xor(this Word word, Word other)
        {
            var wordBytes = word.Value.ToArray();
            var otherBytes = other.Value.ToArray();
            var resultBytes = new List<Entities.Byte>();

            for (var i = 0; i < word.Value.Length; i++)
            {
                resultBytes.Add(wordBytes[i].Xor(otherBytes[i]));
            }

            return new Word(resultBytes.ToArray());
        }
    }
}
