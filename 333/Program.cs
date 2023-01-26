using System;
using System.Collections.Generic;

namespace Laba4
{
    class Program
    {

        static void Main(string[] args)
        {

            First();
        }

        static void First()
        {
           

            var myList = new List();

            myList.Show();

            myList.Add("A");
            myList.Add("B");
            myList.Add("C");
            myList.Show();

            myList.Remove("B");
            myList.Show();

            myList.Clear();
            myList.Show();



            var firstList = new List();
            firstList.Add("A");
            firstList.Add("B");
            firstList.Add("C");
            firstList.Show();
            var secondList = new List();
            secondList.Add("D");
            secondList.Add("E");
            secondList.Add("F");
            secondList.Show();

            Console.WriteLine($"list 1 == list 2  ? - {firstList == myList}");

            Console.Write($"1 list + 2 list: ");

            (firstList + secondList).Show();

            Console.Write($"1 list inversia : ");

            (!firstList).Show();
  
            (firstList < secondList).Show();
            (firstList > secondList).Show();

        }
  
  


        public class List
        {

            public class ListNode
            {
                public string Data { get; set; }
                public ListNode Next { get; set; }
            }


            private int _count;

            public ListNode Head { get; private set; }
            public ListNode Tail { get; private set; }

            //конструкторы
            public List(string data)
            {
                Head = Tail = new ListNode();
                Head.Data = data;
                Tail.Data = data;
                _count = 1;

            }
            public List()
            {
                Head = Tail = new ListNode();
                _count = 0;
            }

            //методы
            public void Add(string data)
            {
                var newNode = new ListNode
                {
                    Data = data
                };

                if (_count == 0)
                {
                    Tail = Head = newNode;
                }
                else
                {
                    Tail.Next = newNode;
                    Tail = newNode;
                }

                _count++;
            }

            public void Remove(string data)
            {

                ListNode current = Head;
                ListNode previous = null;

                while (current != null)
                {
                    if (current.Data == data)
                    {
                        _count--;
                        if (previous == null)
                        {
                            Head = Head.Next;
                            if (Head == null)
                            {
                                Tail = null;
                            }
                            return;
                        }

                        previous.Next = current.Next;

                        if (current.Next == null)
                            Tail = previous;

                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }

            public void Show()
            {
                if (_count == 0)
                {
                    Console.WriteLine("pusto");
                    return;
                }

                if (_count == 1)
                {
                    Console.WriteLine($"{Head.Data}");
                    return;
                }

                ListNode current = Head;

                Console.Write($"{current.Data}");

                current = current.Next;

                while (current.Next != null)
                {
                    Console.Write($"{current.Data}");
                    current = current.Next;
                }
                Console.WriteLine($"{current.Data}");


            }

            public void Clear()
            {
                Head = Tail = new ListNode();
                _count = 0;
            }

            //peregruzka

            public static List operator +(List a, List b)
            {
                List newList = new List();

                if (a._count > 0)
                {
                    var current = a.Head;
                    while (current != null)
                    {
                        newList.Add(current.Data);
                        current = current.Next;
                    }
                }
                if (b._count > 0)
                {
                    var current = b.Head;
                    while (current != null)
                    {
                        newList.Add(current.Data);
                        current = current.Next;
                    }
                }

                return newList;
            }

            public static List operator !(List a)
            {
                if (a._count <= 0) return a;

                var newList = new List();
                var temporary = new string[a._count];
                var counter = a._count - 1;
                var current = a.Head;

                while (current != null)
                {
                    temporary[counter] = current.Data;
                    counter--;
                    current = current.Next;
                }

                foreach (string item in temporary)
                {
                    newList.Add(item);
                }

                return newList;
            }

            public static bool operator ==(List a, List b)
            {
                if (a._count != b._count)
                    return false;

                var currentFirst = a.Head;
                var currentSecond = b.Head;
                while (currentFirst != null)
                {
                    if (currentFirst.Data != currentSecond.Data)
                        return false;
                    currentFirst = currentFirst.Next;
                    currentSecond = currentSecond.Next;
                }

                return true;
            }

            public static bool operator !=(List a, List b)
            {
                return !(a == b);
            }

            public static List operator <(List a, List b)
            {
                return (a + b);
            }

            public static List operator >(List a, List b)
            {
                return (b + a);
            }
        }

    }
}