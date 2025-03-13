namespace FastAndSlowPointer
{
    //https://leetcode.com/problems/happy-number
    //https://leetcode.com/problems/linked-list-cycle-ii

    public class ListNode
    {
        public int Data;
        public ListNode? Next;

        public ListNode(int data, ListNode? next = null)
        {
            data = this.Data;
        }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            head.Next.Next.Next = new ListNode(4);
            //head.Next.Next.Next.Next = head; // Cycle

            var isCycleDetected = HasCycle(head);

            Console.WriteLine(isCycleDetected);
        }

        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.Next == null)
            {
                return false;
            }

            ListNode slow = head;
            ListNode fast = head.Next;

            while (fast != null && fast.Next != null)
            {
                if (slow == fast)
                {
                    return true;
                }
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            return false;
        }
    }
}
