using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AES
{
    public class RoundKeyProvider
    {
        public string GenerateRoundKey(string input, int roundNumber)
        {
            var words = input.ExtractWords();

            var lastWord = words.Last();
            var shittedWord = lastWord.Shift();
            var subWord = shittedWord.SubWord();
            var newWord = subWord.Xor(words.First()).Xor(RconHelper.GetRconWord(roundNumber));
            words.Add(newWord);

            for (int i = 1; i <= 3; i++)
            {
                var oldWord = words.Skip(i).First();
                var prevWord = words.Last();
                var generatedWord = oldWord.Xor(prevWord);
                words.Add(generatedWord);
            }

            return string.Join(" | ", words.Skip(4).Select(v => v.ToString()));
        }
    }
}
