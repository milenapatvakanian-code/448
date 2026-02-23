using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _448
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hello,World!");
            Node first = new Node { Value = 3 };
            Node second = new Node { Value = 6 };
            Node third = new Node { Value = 8 };
            Node fourth = new Node { Value = 10 };
            Node fifth = new Node { Value = 7 };

            first.Next = second;
            second.Next = third;
            third.Next = fourth;
            fourth.Next = fifth;
            fifth.Next = null;
            Print(fourth);

            void Print(Node node)
            {
                while (node != null)
                {
                    Console.WriteLine(node.Value);
                    node = node.Next;

                }
            }

        }
    }
}
