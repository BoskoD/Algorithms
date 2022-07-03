//https://leetcode.com/explore/interview/card/top-interview-questions-easy/93/linked-list/553/
using System;

namespace DeleteNodeInLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddAtHead(9);
            linkedList.AddAtHead(1);
            linkedList.AddAtHead(5);
            linkedList.AddAtHead(4);
            
            Console.Write("Before deletion\n");
            linkedList.Print();

            Console.Write("After deletion\n");
            ListNode node = linkedList.Find(1);
            linkedList.DeleteNode(node);
            linkedList.Print();
        }
    }

    public class ListNode
    {
        public int value;
        public ListNode next;
        public ListNode(int x) 
        { 
            value = x; 
        }
    }

    public class LinkedList
    {
        ListNode head = null;
        ListNode tail = null;
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
                Console.WriteLine(current.value);
                current = current.next;
            }
        }

        public void AddAtHead(int data)
        {
            ListNode node = new ListNode(data);
            if (size == 0) head = tail = node;
            else
            {
                node.next = head;
                head = node;
            }
            size++;
        }

        public ListNode Find(int value)
        {
            if (head == null) return null;
            ListNode current = head;
            while (current != null)
            {
                if (current.value == value) return current;
                current = current.next;
            }
            return null;
        }

        public void DeleteNode(ListNode node)
        {
            node.value = node.next.value;
            node.next = node.next.next;
        }
    }
}