using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Tree
{
    class Node
    {
        public int nodeValue { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public int level { get; set; }
        public Node LeftSibling { get; set; }
        public Node RightSibling { get; set; }
    }
}
