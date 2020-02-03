using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;
            SingleLinkedList list = new SingleLinkedList();

            list.CreateList();
            
            while(true)
            {
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Count the number of nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Delete Repeating Nodes");
                Console.WriteLine("5. Quit");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    break;
                }
                

                switch(choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        list.CountNodes();
                        break;
                    case 4:
                        list.DeleteRepeatingNodes();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exiting");
            
        }
    }
}
