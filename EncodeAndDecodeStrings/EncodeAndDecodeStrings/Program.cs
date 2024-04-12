namespace EncodeAndDecodeStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = ["lint", "code", "love", "you"];

            string encoded = Encode(input);
            Console.WriteLine($"\nEncoded: {encoded}\n");
            
            Console.WriteLine("\nDecoded:\n");
            IList<string> decoded = Decode(encoded);
            foreach (string item in decoded)
            {
                Console.Write(item);
            }
        }

        public static string Encode(IList<string> str)
        {
            return string.Concat(str.SelectMany(s => $"{s.Length}#{s}"));
        }

        public static IList<string> Decode(string input) // 4#lint4#code4#love3#you
        {
            IList<string> result = [];

            int i = 0;
            while (i < input.Length)
            {
                int j = i;
                while (input[j] != '#')
                {
                    ++j;
                }

                _ = int.TryParse(input.AsSpan(i, j - i), out int len);
                j++;
                result.Add(input.Substring(j, len));
                i = j + len;
            }
            
            return result;
        }
    }
}
