using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class SingleLinkedList
    {
        private Node start;
        public SingleLinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p;
            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Console.Write("List is :  ");
            p = start;
            while(p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }

        public void CreateList()
        {
            int i, n; char data;
            Console.Write("Enter the number of nodes : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;
            for(i = 1; i <= n; i++)
            {
                Console.Write("Enter the element to be inserted : ");
                data = Convert.ToChar(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void DeleteRepeatingNodes()
        {
            Node temp = null; 
            Node prev; int choice;

            int n = 0;
            Node pq = start;

             if (pq == null)
             {
                 pq = temp;
                 return;
             } 

                 Int32 noofnodes = ReturnNodes();
                // for (n = 1; n <= noofnodes;n++ )
                // {
                     while (pq != null)
                     {
                         
                         if (pq == pq.link)
                         {
                             pq = pq.link.link;
                             pq.link = temp;
                             
                         }
                         else
                         {
                             pq = pq.link;
                         }
                         DisplayList();
                         
                     }                    
                // }
                 return;
        }

        public void InsertAtEnd(char data)
        {
            Node p;
            Node temp = new Node(data);

            if(start == null)
            {
                start = temp;
                return;
            }

            p = start;
            while (p.link != null)
                p = p.link;

            p.link = temp;
        }

        public Int32 ReturnNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
            return n;
            //Console.WriteLine("Number of nodes in the list = " + n);
        }

        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while(p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("Number of nodes in the list = " + n);
        }

        public bool Search(char x)
        {
            int position = 1;
            Node p = start;
            while(p != null)
            {
                if(p.info == x)
                    break;
                    position++;
                    p = p.link;
            }
            if(p == null)
            {
                Console.WriteLine(x + " not found in the list");
                return false;
            }
            else
            {
                Console.WriteLine(x + " is at position " + position);
                return true;
            }
        }
    }
}
