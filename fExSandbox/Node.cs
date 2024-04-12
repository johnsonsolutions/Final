using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fExSandbox
{
    internal class Node
    {
        // basic node information
        public string name;
        public int x;
        public int y;
        public Button button;
        public int player;

        /* Neighboring nodes
            naming convention uses cardinal direction of the node in reference to the current node
            with a lower case inital (n is North, w is West, etc..) (North or South take precendence over
            east or west (for example: North West is nwNeighbor not wnNeighbor)*/
        Node nNeighbor;
        Node neNeighbor;
        Node eNeighbor;
        Node seNeighbor;
        Node sNeighbor;
        Node swNeighbor;
        Node wNeighbor;
        Node nwNeighbor;


        //public  Data { get; set; }
       /// public List<Node> Children { get; set; }

       // public float weight;
    

       /// public bool isTerminal() { return Children.Count < 1; }

        public Node(int x,int y, Button button)
        {
            this.x = x;
            this.y = y;
            this.button = button;
            //this.button = Connect4.GetButton();
            //Data = data;
            //Children = new List<Node<T>>();
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

        /*public float MiniMax<T>(Node<T> node, int depth, bool maximizingPlayer)
        {
            if (depth == 0 || isTerminal())
            {
                return node.weight;
            }

            if (maximizingPlayer)
            {
                float weight = 0;
                foreach (Node<T> child in node.Children)
                {
                    weight = Math.Max(weight, MiniMax(child, depth - 1, false));
                }
                return weight;
            }
            else
            {
                float weight = 0;
                foreach (Node<T> child in node.Children)
                {
                    weight = Math.Min(weight, MiniMax(child, depth - 1, true));
                }
                return weight;
            }*/
        //}
    }
}
