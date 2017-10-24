using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Tree
{
    class Node
    {
        public int Data { get { return data; } set { data = value; } }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Peer { get; set; }
        private int data;
        public Node(int data)
        {
            this.data = data;
        }
        public int DataValue()
        {
            return data;
        }
    }
}
