using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fExSandbox
{
    public class Slot
    {
        // basic node information
        public string name;
        public int x;
        public int y;
        public Button button;
        public int player;

        public List<Slot> winNodes;

        //public  Data { get; set; }
       /// public List<Node> Children { get; set; }

       // public float weight;
    

       /// public bool isTerminal() { return Children.Count < 1; }

        public Slot(int x,int y, Button button)
        {
            this.x = x;
            this.y = y;
            //this.coordinates[x, y] = x;
            this.button = button;
            //this.button = Connect4.GetButton();
            //Data = data;
            //Children = new List<Node<T>>();
        }
        public static int Find(List<Slot> ns, Point loc)
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

        public void CheckVertical(Slot slot, Node gameState)
        {
            //Create list of possible winning nodes and add the dropped piece
            gameState.winNodes.Add(slot);

            ///Check node north of current node, and all nodes above that
            slot.CheckNorth(slot, gameState);
            slot.CheckSouth(slot, gameState);

            if (gameState.winNodes.Count >= 4)
            {
                /// winner is active player
                Application.Exit();
            }
            else
            {
                //clear list if theres no winner
                gameState.winNodes.Clear();
            }

        }

        public void CheckNorth(Slot slot, Node gameState)
        {
            foreach (Slot n in gameState.state)
            {
                if (n.x == slot.x && n.y == slot.y + 1)
                {
                    //check if it is the same color
                    if (n.player == slot.player)
                    {
                        //add to possible winning nodes and check that piece
                        gameState.winNodes.Add(n);
                        slot.CheckNorth(n, gameState);
                    }
                }
            }
        }
        public void CheckSouth(Slot slot, Node gameState)
        {
            foreach (Slot n in gameState.state)
            {
                if (n.x == slot.x && n.y == slot.y - 1)
                {
                    //check if it is the same color
                    if (n.player == slot.player)
                    {
                        //add to possible winning nodes and check that piece
                        gameState.winNodes.Add(n);
                        slot.CheckSouth(n, gameState);
                    }
                }
            }
        }

        public void CheckHorizontal(Slot slot, Node gameState)
        {
            //Create list of possible winning nodes and add the dropped piece
            gameState.winNodes.Add(slot);

            ///Check nodes west and east of current node
            slot.CheckWest(slot, gameState);
            slot.CheckEast(slot, gameState);

            if (gameState.winNodes.Count >= 4)
            {
                /// winner is active player
                Application.Exit();
            }
            else
            {
                //clear list if theres no winner
                gameState.winNodes.Clear();
            }
        }

        public void CheckWest(Slot slot, Node gameState)
        {
            foreach (Slot n in gameState.state)
            {
                if (n.x == slot.x - 1 && n.y == slot.y)
                {
                    //check if it is the same color
                    if (n.player == slot.player)
                    {
                        //add to possible winning nodes and check that piece
                        gameState.winNodes.Add(n);
                        slot.CheckWest(n, gameState);
                    }
                }
            }
        }

        public void CheckEast(Slot slot, Node gameState)
        {
            foreach (Slot n in gameState.state)
            {
                if (n.x == slot.x + 1 && n.y == slot.y)
                {
                    //check if it is the same color
                    if (n.player == slot.player)
                    {
                        //add to possible winning nodes and check that piece
                        gameState.winNodes.Add(n);
                        slot.CheckEast(n, gameState);
                    }
                }
            }
        }

        public void CheckPosDiagonal(Slot slot, Node gameState)
        {
            //Create list of possible winning nodes and add the dropped piece
            gameState.winNodes.Add(slot);

            ///Check nodes west and east of current node
            slot.CheckNorthEast(slot, gameState);
            slot.CheckSouthWest(slot, gameState);

            if (gameState.winNodes.Count >= 4)
            {
                /// winner is active player
                Application.Exit();
            }
            else
            {
                //clear list if theres no winner
                gameState.winNodes.Clear();
            }
        }

        public void CheckNorthEast(Slot slot, Node gameState)
        {
            foreach (Slot n in gameState.state)
            {
                if (n.x == slot.x + 1 && n.y == slot.y + 1)
                {
                    //check if it is the same color
                    if (n.player == slot.player)
                    {
                        //add to possible winning nodes and check that piece
                        gameState.winNodes.Add(n);
                        CheckNorthEast(n, gameState);
                    }
                }
            }
        }

        public void CheckSouthWest(Slot slot, Node gameState)
        {
            foreach (Slot n in gameState.state)
            {
                if (n.x == slot.x - 1 && n.y == slot.y - 1)
                {
                    //check if it is the same color
                    if (n.player == slot.player)
                    {
                        //add to possible winning nodes and check that piece
                        gameState.winNodes.Add(n);
                        slot.CheckSouthWest(n, gameState);
                    }
                }
            }
        }

        public void CheckNegDiagonal(Slot slot, Node gameState)
        {
            //Create list of possible winning nodes and add the dropped piece
            gameState.winNodes.Add(slot);

            ///Check nodes west and east of current node
            slot.CheckNorthWest(slot, gameState);
            slot.CheckSouthEast(slot, gameState);

            if (gameState.winNodes.Count >= 4)
            {
                // winner is active player
                Application.Exit();
            }
            else
            {
                //clear list if theres no winner
                gameState.winNodes.Clear();
            }
        }

        public void CheckNorthWest(Slot slot, Node gameState)
        {
            foreach (Slot n in gameState.state)
            {
                if (n.x == slot.x - 1 && n.y == slot.y + 1)
                {
                    //check if it is the same color
                    if (n.player == slot.player)
                    {
                        //add to possible winning nodes and check that piece
                        gameState.winNodes.Add(n);
                        slot.CheckNorthWest(n, gameState);
                    }
                }
            }
        }

        public void CheckSouthEast(Slot slot, Node gameState)
        {
            foreach (Slot n in gameState.state)
            {
                if (n.x == slot.x + 1 && n.y == slot.y - 1)
                {
                    //check if it is the same color
                    if (n.player == slot.player)
                    {
                        //add to possible winning nodes and check that piece
                        gameState.winNodes.Add(n);
                        slot.CheckSouthEast(n, gameState);
                    }
                }
            }
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
    public class Node {

        public List<Slot> state = new List<Slot>();
        public float impurity;
        public float infoGain;
        public List<Slot> winNodes;

        public Node[] children = new Node[7];

        public Node() { }
        public Node(Slot[] slots) { 
            foreach (Slot slot in slots) { state.Add(slot); }
        }
        public Node(List<Slot> slots) { state = slots; }


        void EvalChildren() { 
            for(int i = 0; i < children.Length; i++)
            {
                if (children[i] != null) { 
                    
                }
            }
        }
    }
}
