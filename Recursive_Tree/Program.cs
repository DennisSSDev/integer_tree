using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/// <summary>
/// IMPORTANT!!!
/// 
/// The output will be given without graphics so imagine the output as if you read from the furthest left top node to the furthest right node. 
/// 
/// When you don't have any nodes left on that depth go to next level and read from there
/// 
/// At some point the console window won't be large enought to keep the data aligned, so please keep it readable to yourself :)
/// </summary>
namespace Recursive_Tree
{
    class Program
    {
        static void Main(string[] args)//Going Treeless
        {
            List<Node> nodes = new List<Node>();
            int maxlevel = -1;
            Node t = null;

            // populate level 0
            nodes.Add(new Node { nodeValue = 1, LeftChild = null, RightChild = null, RightSibling = null, LeftSibling = null });
            Console.WriteLine("Specify Depth: ");
            int.TryParse( Console.ReadLine(), out maxlevel);
            if(maxlevel < 0)
            {
                return;
            }
            //Main algorithm, where I took an itirative approach to solving the problem, instead of using recursion
            //Keep a reference to left and right node from list
            for (int i = 1; i < maxlevel; i++)
            {
                var prevLevel = nodes.Where(n => n.level == i - 1).ToArray();
                Node lastNode = null;
                for (int h = 0; h < prevLevel.Count(); h++)
                {
                    var item = prevLevel[h];
                    for (int j = 0; j < 2; j++)
                    {
                        Node newNode = new Node
                        {
                            level = i,
                            LeftSibling = lastNode
                        };
                        newNode.nodeValue = item.nodeValue;
                        if (j == 0)
                            newNode.nodeValue += ((item.LeftSibling) == null ? 0 : item.LeftSibling.nodeValue);
                        else
                            newNode.nodeValue += ((item.RightSibling) == null ? 0 : item.RightSibling.nodeValue);

                        if (lastNode != null)
                            lastNode.RightSibling = newNode;

                        lastNode = newNode;
                        if (j == 0)
                            item.LeftChild = newNode;
                        else
                            item.RightChild = newNode;
                        nodes.Add(newNode);
                    }
                }
            }
            //TExt representation
            foreach (var item in nodes)
            {
                
                if (t==null|| t.level < item.level)
                    Console.Write("\n" + item.nodeValue);
                else
                    Console.Write(item.nodeValue);

                t = item;
            }
            Console.WriteLine("\n");
        }
    }
}
