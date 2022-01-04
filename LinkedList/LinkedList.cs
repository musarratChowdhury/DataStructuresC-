using System;

namespace LinkedList;
	public class LinkedList
	{
		public Node head;//Head of list
			
		public  class Node
		{

			public int data;
			public Node next;
		//constructor
			public Node(int d)
			{
				data = d;
				next = null;	
			}
		}
	//to print
	public void printList()
	{
		Node n = head;
		while (n != null)
		{
			Console.WriteLine(n.data+" ");
			n = n.next;	
		}
	}
	}
	
