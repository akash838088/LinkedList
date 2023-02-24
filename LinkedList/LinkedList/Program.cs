using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Option");
                Console.WriteLine("1:Create linked list");
                Console.WriteLine("2:Display");
                Console.WriteLine("3:ReverseContact");
                Console.WriteLine("4:Append");
                Console.WriteLine("5:Remove First Node");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                     case 2:
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.InReverse(56);
                        linkedList.InReverse(30);
                        linkedList.InReverse(70);
                        break;
                    case 4:
                        linkedList.Append(56);
                        linkedList.Append(30);
                        linkedList.Append(70);
                        break;
                    case 5:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirstNode();
                        break;
                    default:
                        Console.WriteLine("Enter correct option");
                        break;
                }
            }
        }
    }
}