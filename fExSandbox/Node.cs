using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fExSandbox
{
    internal class Node<T>
    {
        public string name;

        public T Data { get; set; }
        public List<Node<T>> Children { get; set; }

        public float weight;

        public bool isTerminal() { return Children.Count < 1; }

        public Node(T data)
        {
            Data = data;
            Children = new List<Node<T>>();
        }
        public void AddChild(Node<T> child)
        {
            Children.Add(child);
        }

        /// <summary>
        /// Traverse Tree
        /// </summary>
        /// <param name="depth">Depth Traversed</param>
        public void DFSSweep(int depth)
        {
            Console.Write($"Node Visited:{this.Data}");
            foreach (var child in this.Children)
            {
                child.DFSSweep(depth + 1);
            }
        }


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
        }

        public void RemoveNode<T>(Node<T> node, Node<T> DeadNode)
        {
            node.Children.Remove(DeadNode);
        }

        public float MiniMax<T>(Node<T> node, int depth, bool maximizingPlayer)
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
            }
        }
    }
}
