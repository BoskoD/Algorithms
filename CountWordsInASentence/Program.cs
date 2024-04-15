
namespace CountWordsInASentence
{
    internal class Program // Array, String
    {
        static void Main(string[] args)
        {
            string[] sentences = ["alice and bob love leetcode", "i think so too", "this is great thanks very much"];
            int result = MaxNumberOfWordsWithLINQ(sentences);
            Console.WriteLine(result);
        }

        private static int MaxNumberOfWords(string[] sentences)
        {
            int maxValue = 0;

            foreach (string sentence in sentences)
            {
                int spaceCounter = 0;
                foreach (char c in sentence)
                {
                    if (c == ' ') { spaceCounter++; }
                }
                int wordCount = spaceCounter + 1;
                if (wordCount > maxValue)
                { maxValue = wordCount; }
            }
            return maxValue;
        }

        private static int MaxNumberOfWordsWithLINQ(string[] sentences) => sentences.Select(sentence => sentence.Split(' ').Length).Max();
    }
}
