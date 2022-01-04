using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;
using static Algorithms.CustomLinkedList;

//using static LinkedList.LinkedList;

namespace LinkedList
{
	public class program
	{
		public static void Main( string[] args )
		{
			//var llist = new LinkedList();

			////
			//llist.head = new Node(1);
			//Node second = new Node(2);
			//Node third = new Node(3);
			////
			//llist.head.next = second;
			//second.next = third;
			////
			//llist.printList();
			////built in linkedList
			//LinkedList<string> listy =  new LinkedList<string>();
			////Addlast
			//listy.AddLast("sarah");
			//listy.AddLast("Polly");
			//listy.AddLast("Rebecca");
			//listy.AddLast("Jesseca");

			////Addfirst


			////
			//Console.WriteLine(listy.Contains("Jess"));
			//Console.WriteLine(listy.Count);

			//listy.RemoveFirst();


			//foreach(string item in listy)
			//{
			//	Console.WriteLine(item);
			//}
			//
			CustomLinkedList mylinkedList = new CustomLinkedList();
			Node firstNode = new Node(3);
			Node secondNode = new Node(4);
			Node thirdNode = new Node(5);
			Node fourthNode = new Node(6);
			Node fifthNode = new Node(7);

			mylinkedList.head  =  firstNode;
			firstNode.next = secondNode;
			secondNode.next = thirdNode;	
			thirdNode.next = fourthNode;
			fourthNode.next = fifthNode;

			//
			mylinkedList.displayContents();
			//mylinkedList.deleteBackHalf();
			Console.WriteLine();
			mylinkedList.displayContents();
			Console.WriteLine("..........");
			int nodeTOdlet = 5;
			mylinkedList.deleteKthNode(nodeTOdlet);
			Console.WriteLine($"after deleting {nodeTOdlet}th node");
			mylinkedList.displayContents();

		}
	}
}
