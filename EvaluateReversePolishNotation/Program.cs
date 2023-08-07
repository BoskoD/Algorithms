namespace EvaluateReversePolishNotation
{
    internal class Program // Array, Math, Stack
    {
        static void Main(string[] args)
        {
            string[] tokens = { "2", "1", "+", "3", "*" };
            int result = RPN(tokens);
            Console.WriteLine($"Result is {result}.");
        }

        public static int RPN(string[] tokens)
        {
            Stack<int> stack = new();
            int result = 0;

            foreach (var token in tokens)
            {
                int number = 0;
                bool isNumber = int.TryParse(token, out number);
                if (isNumber)
                {
                    stack.Push(number);
                }
                else 
                {
                    result = Evaluate(stack.Pop(), stack.Pop(), token);
                    stack.Push(result);
                }
            }
            return stack.Pop();
        }

        public static int Evaluate(int b, int a, string operation)
        {
            return operation switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => a / b,
                _ => throw new Exception(),
            };
        }
    }
}