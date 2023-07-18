namespace ValidParentheses
{
    internal class Program // String, Stack
    {
        static void Main(string[] args)
        {
            var input = "{[()]}";
            var isValid = IsValidParentheses(input);
            Console.WriteLine($"Order of parentheses is valid: {isValid}");
        }

        public static bool IsValidParentheses(string input)
        {
            var mapping = new Dictionary<char, char>
            {
                { '(', ')'},
                { '[', ']'},
                { '{', '}'}
            };

            Stack<char> openBrackets = new();

            foreach (var c in input)
            {
                if (mapping.ContainsKey(c))
                {
                    openBrackets.Push(c);
                }
                else
                {
                    if (openBrackets.Count == 0) { return false; }
                    if (mapping[openBrackets.Pop()] == c) { continue; }
                    return false;
                }
            }
            return openBrackets.Count == 0;
        }
    }
}