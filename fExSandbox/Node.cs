using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fExSandbox
{
    public class Node
    {
        // basic node information
        public string name;
        public int x;
        public int y;
        public Button button;
        public int player;
        public List<Node> children;


        //public  Data { get; set; }
       /// public List<Node> Children { get; set; }

       // public float weight;
    

       /// public bool isTerminal() { return Children.Count < 1; }

        public Node(int x,int y, Button button)
        {
            this.x = x;
            this.y = y;
            //this.coordinates[x, y] = x;
            this.button = button;
            //this.button = Connect4.GetButton();
            //Data = data;
            List<Node> children = new List<Node>();
        }
        public static int Find(List<Node> ns, Point loc)
        {
            for (int i = 0; i < ns.Count; i++)
            {
                if (ns[i].x == loc.X && ns[i].y == loc.Y)
                {
                    return i;
                }
            }

            return -1;
        }



        /* public void AddChild(Node child)
         {
             Children.Add(child);
         }*/

        /// <summary>
        /// Traverse Tree
        /// </summary>
        /// <param name="depth">Depth Traversed</param>
        /*
        public void DFSSweep(int depth)
        {
            Console.Write($"Node Visited:{this.Data}");
            foreach (var child in this.Children)
            {
                child.DFSSweep(depth + 1);
            }
        }
        */

        /*
        public Node<T> FindNode<T>(Node<T> currentNode, T searchData)
        {
            if (currentNode.Data.Equals(searchData))
            {
                return currentNode;
            }
            foreach (var child in currentNode.Children)
            {
                var foundNode = FindNode(child, searchData);
                if (foundNode != null)
                {
                    return foundNode;
                }
            }
            return null;
        }*/


        /*public void RemoveNode<T>(Node<T> node, Node<T> DeadNode)
         {
             node.Children.Remove(DeadNode);
         }*/

        /*
        public float MiniMax<T>(Node node, int depth, bool maximizingPlayer)
        {
            if (depth == 0 || isTerminal())
            {
                return node.weight;
            }

            if (maximizingPlayer)
            {
                float weight = 0;
                foreach (Node child in node.children)
                {
                    weight = Math.Max(weight, MiniMax(child, depth - 1, false));
                }
                return weight;
            }
            else
            {
                float weight = 0;
                foreach (Node child in node.children)
                {
                    weight = Math.Min(weight, MiniMax(child, depth - 1, true));
                }
                return weight;
            }
        }*/
    }
}
