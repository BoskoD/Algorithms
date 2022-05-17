using System;
using System.Collections.Generic;

namespace TwoCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();

            // Obtain all the possible combination of possible characters in the string
            //e.g. for input string abdcab we need to find ab,ac,ad,bc,bd,cd combinations
            var characterSet = new HashSet<char>();
            var combinationList = new List<Tuple<char, char>>();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (!characterSet.Contains(inputString[i]))
                {
                    // Create all tuple combinations
                    foreach (var character in characterSet)
                    {
                        combinationList.Add(new Tuple<char, char>(inputString[i], character));
                    }
                }
                characterSet.Add(inputString[i]);
            }

            var maxPatternsLength = 0;

            foreach (var alternatingCharPair in combinationList)
            {
                //process the entire input string once for each combination if it gives max length of alternating characters
                var nextExpectedChar = alternatingCharPair.Item2;
                var currentPatternLength = 1;
                var i = 0;
                while (inputString[i] != alternatingCharPair.Item1 && 
                       inputString[i] != alternatingCharPair.Item2)
                {
                    i++;
                }

                if (inputString[i] == alternatingCharPair.Item2)
                {
                    nextExpectedChar = alternatingCharPair.Item1;
                }
                i++;

                for (; i < inputString.Length; i++)
                {
                    if (inputString[i] != alternatingCharPair.Item1 &&
                        inputString[i] != alternatingCharPair.Item2)
                        continue;

                    if (inputString[i] == nextExpectedChar)
                    {
                        currentPatternLength++;

                        nextExpectedChar = inputString[i] ==
                            alternatingCharPair.Item1 ?
                            alternatingCharPair.Item2 : 
                            alternatingCharPair.Item1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (i == inputString.Length && currentPatternLength > maxPatternsLength)
                {
                    //it has valid alternating pattern
                    maxPatternsLength = currentPatternLength;
                }
            }
            Console.WriteLine(maxPatternsLength);
        }
    }
}