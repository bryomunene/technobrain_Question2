using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public char info;
        public Node link;

        public Node(char str)
        {
            info = str;
            link = null;
        }
    }
}
