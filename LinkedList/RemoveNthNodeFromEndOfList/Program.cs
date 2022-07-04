//https://leetcode.com/explore/interview/card/top-interview-questions-easy/93/linked-list/603/
using System;

namespace RemoveNthNodeFromEndOfList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddAtHead(5);
            list.AddAtHead(4);
            list.AddAtHead(3);
            list.AddAtHead(2);
            list.AddAtHead(1);
            
            Console.WriteLine("Before removal");
            list.Print();

            Console.WriteLine("After removal");
            var head = list.head;
            list.RemoveNthFromEnd(head, 2);
            list.Print();
        }
    }

    public class ListNode
    {
        public int Data { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        public ListNode head;
        public ListNode tail;
        int size = 0;

        public void Print()
        {
            ListNode current = head;

            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public void AddAtHead(int data)
        {
            ListNode node = new ListNode(data);
            if (size == 0) head = tail = node;
            else
            {
                node.Next = head;
                head = node;
            }
            size++;
        }

        public int SearchValue(int value)
        {
            if (head == null) return -1;
            ListNode current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Data == value) return index;
                index++;
                current = current.Next;
            }
            return -1;
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var left = head;
            var right = head;

            while (right != null)
            {
                right = right.Next;
                if (n-- < 0) left = left.Next;
            }

            if (n == 0) head = head.Next;
            else left.Next = left.Next.Next;

            return head;
        }
    }
}