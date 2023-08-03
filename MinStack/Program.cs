namespace MinStack
{
    internal class Program // Stack, Design
    {
        static void Main(string[] args)
        {
            MinimumStack<int> stack = new MinimumStack<int>();
            stack.Push(-2);
            stack.Push(0);
            stack.Push(-3);

            Console.WriteLine($"Min from the stack is {stack.GetMin()}\n");
            stack.Pop();
            Console.WriteLine($"Top after removing from the top of the stack: {stack.Top()}\n");
            Console.WriteLine($"New min: {stack.GetMin()}");
        }
    }

    public class MinimumStack<T>
    {
        readonly Stack<int> stack;
        readonly Stack<int> minStack;

        public MinimumStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int val) 
        {
            stack.Push(val);
            int min = Math.Min(val, minStack.Count > 0 ? minStack.Peek() : val);
            minStack.Push(min);
        }

        public void Pop() 
        {
            stack.Pop();
            minStack.Pop();
        }

        public int Top() 
        {
            return stack.Peek();
        }

        public int GetMin() 
        {
            return minStack.Peek();
        }
    }
}