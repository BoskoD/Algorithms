//https://www.hackerrank.com/challenges/designer-pdf-viewer/problem?isFullScreen=true
using System;
using System.Collections.Generic;

namespace DesignerPDFViewer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] alphabetHeight = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            string word = "zaba";

            int hightlightedWord = Result.DesignerPDFView(alphabetHeight, word);
            Console.WriteLine(hightlightedWord);
        }
    }

    internal class Result
    {
        internal static int DesignerPDFView(int[] inputHeights, string word)
        {
            var alphabet = 'a';
            var alphabetDictionary = new Dictionary<char, int>();

            foreach (var item in inputHeights)
            {
                alphabetDictionary.Add(alphabet++, item);
            }

            var maxAlphabetHeight = 0;

            foreach (var character in word)
            {
                if (alphabetDictionary[character] > maxAlphabetHeight)
                {
                    maxAlphabetHeight = alphabetDictionary[character];
                }
            }
            var areaOfSelectedText = maxAlphabetHeight * word.Length;
            return areaOfSelectedText;
        }
    }
}