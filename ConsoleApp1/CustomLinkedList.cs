﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	internal class CustomLinkedList
	{
		public Node head;
		public static int counter = 0;
		public class Node
		{
			public int count = 0;

			public int data;
			public Node next;
			

			//
			public Node( int d )
			{
				data = d;
				next = null;
				CustomLinkedList.counter++;
			}
		}
		//
		public void deleteBackHalf()
		{
			if (head == null || head.next == null)
			{
				head = null;
			}
			Node slow = head;
			Node fast = head;
			Node prev = null;

			while(fast!= null && fast.next!=null)
			{
				prev = slow;
				slow = slow.next;
				fast = fast.next.next;
			}
			prev.next = null;
		}
		public void deleteKthNode(int k)
		{
			if (head == null || k == 0) return;
			if(k == CustomLinkedList.counter)
			{
				head = head.next;
				return;
			}
			Node current = head;


			Node prev = null;
			current.count = CustomLinkedList.counter;
			Node kth = null;

			while(current != null)
			{
				//Console.Write(current.data+"->");
				prev = current;
				
				current = current.next;
				current.count = prev.count;
				current.count--;
				if(current.count ==  k)
				{
					kth = current;
					if(kth.next != null)
					prev.next = kth.next;
					else
					prev.next = null;
					break;
				}
				
			}

			//Console.WriteLine(last.data);
		}

		public void displayContents()
		{
			Node current = head;
			while (current != null)
			{
				Console.Write(current.data + "->");
				current = current.next;
			}
		}
	}
}
