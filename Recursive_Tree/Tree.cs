using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Tree
{
    class Tree
    {
        Node root = null;
        int counter = 1;
        int value_of_LeftChild = 0;
        int value_of_RightChild = 0;
        bool LeftOrRight;//if the node is left it's true, if it's right it's false;
        public Tree()
        {
        }

        public void Insert(int goal)
        {
            if(root == null)
            {
                root = new Node(1);
            }
            Insert(root, goal);
        }
        public void Print()
        {
            Print(root, 1);
        }

        private void Insert(Node nodeP, int goal)
        {
            while (counter !=goal)
            {
                if(nodeP == null)
                {

                }
                counter++;
                Insert(nodeP.Left, goal);
                Insert(nodeP.Right, goal);
            }
            
        }
        private void Print(Node node, int level)
        {

        }




        /*if (nodeP == null)
            {
                if (Peer != null)
                {
                    nodeP = new Node(dataP + Peer.Data);
                }
                else
                {
                    nodeP = new Node(dataP);
                }
            }
            if (counter >= goal)
            {
                return;
            }
            else
            {
                counter++;
            }
            Insert(nodeP.DataValue(), nodeP.Left, goal, nodeP);
            Insert(nodeP.DataValue(), nodeP.Right, goal, nodeP);
            value_of_LeftChild = nodeP.DataValue();
            value_of_RightChild = nodeP.DataValue();
            */
    }
}
