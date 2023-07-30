namespace ReverseLinkedList
{
    internal class Program // LinkedList, Two Pointers
    {
        static void Main(string[] args)
        {
            var list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            var reversedList = ReverseList(list);

            while (reversedList != null)
            {
                Console.Write(reversedList.val);
                if (reversedList.next != null)
                {
                    Console.Write("-> ");
                }
                reversedList = reversedList.next;
            }
        }

        public static ListNode ReverseList(ListNode head)
        {
            ListNode current = head;
            ListNode previous = null;

            while (current != null)
            {
                var temp = current.next;
                current.next = previous;
                previous = current;
                current = temp;
            }
            return previous;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}