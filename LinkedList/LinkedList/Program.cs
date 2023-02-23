using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Option");
                Console.WriteLine("1:Create linked list\n2: Display ");
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
                    default:
                        Console.WriteLine("Enter Correct Option");
                        break;
                }
            }
        }
    }
}