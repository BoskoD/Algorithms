using System.Text;

namespace GenerateParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            var result = Generate(n);
            foreach (var s in result)
            {
                System.Console.WriteLine(s);
            }
        }

        public static IList<string> Generate(int n)
        {
            var result = new List<string>();
            var sequence = new StringBuilder();

            void BacktrackParentheses(int openCount, int closedCount)
            {
                // Base case
                if (sequence.Length == n * 2)
                {
                    result.Add(sequence.ToString());
                    return;
                }

                if (openCount < n)
                {
                    sequence.Append("(");
                    BacktrackParentheses(openCount + 1, closedCount);
                    sequence.Remove(sequence.Length - 1, 1);
                }

                if (openCount > closedCount)
                {
                    sequence.Append(")");
                    BacktrackParentheses(openCount, closedCount + 1);
                    sequence.Remove(sequence.Length - 1, 1);
                }
            }
            BacktrackParentheses(0, 0);
            return result;
        }
    }
}