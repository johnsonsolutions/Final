using fExSandbox.Properties;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace fExSandbox
{
    public partial class Connect4 : Form
    {
        /*Preferences*/
        public bool AI = false;
        //Images for player pieces in order [Empty, Player 1, Player 2]
        Bitmap[] Faces = new Bitmap[3] { Properties.Resources.t1_01, Properties.Resources.t2_01, Properties.Resources.t3_01 };

        /*Data*/
        //Current player's turn
        int activePlayer = 1;
        //Node[] nodes = new Node[42];
        List<Node> nodes = new List<Node>();
        // possible winning nodes
        List<Node> winNodes = new List<Node>();


        //Event Handling
        public delegate void dropHandler(Point loc);
        public event dropHandler? Drop;

        /*UI*/
        public List<Point> gridScale = new List<Point>();

        /*Controls*/
        List<Button> btns = new List<Button>();

        public Connect4()
        {
            InitializeComponent();
            /*Event Handlers*/
            //Drop += mockCDrop;
            Drop += ColDrop;

            //InitNodes();
            mockNodes();
            //nodeTest();
            //grabMe();
        }

        void nodeTest()
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                yell($"Node {i}:\n - Location: ({nodes[i].x}, {nodes[i].y})");
            }
        }

        /// <summary>
        /// Generates spaced-out button locations
        /// </summary>
        public void scaleGrid()
        {
            int yPos = 55;
            int fac = 86;
            Point current = new Point(12, yPos);

            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    gridScale.Add(current);
                    current.Y += fac;
                }
                current.X += fac;
                current.Y = yPos;
            }
        }

        /// <summary>
        /// Returns a new formatted button
        /// </summary>
        /// <param name="name">Button name/param>
        /// <returns>Formatted Button</returns>
        public Button newBtn(string name)
        {
            Button spawn = new Button();

            spawn.Name = name;
            spawn.BackColor = Color.Transparent;
            spawn.BackgroundImage = Properties.Resources.t1_01;
            spawn.BackgroundImageLayout = ImageLayout.Stretch;
            spawn.FlatAppearance.BorderSize = 0;
            spawn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            spawn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            spawn.FlatStyle = FlatStyle.Flat;
            spawn.Name = name;
            spawn.Size = new Size(80, 80);
            spawn.TabIndex = 1;
            spawn.UseVisualStyleBackColor = false;
            return spawn;
        }

        /// <summary>
        /// Print a string to the display/output
        /// </summary>
        /// <param name="inp">Input string</param>
        public void yell(string inp)
        {
            //txtDisp.Text = inp;
            Debug.WriteLine(inp);
        }


        /// <summary>
        /// Mockup of initNodes(); Combined with the button generation and grid scaling
        /// </summary>
        public void mockNodes()
        {
            scaleGrid();
            int i = 0;
            int ev = 1;
            for (int x = 0; x < 7; x++)
            {

                for (int y = 0; y < 6; y++)
                {
                    string btnName = "btn" + y.ToString() + x.ToString();
                    Button button = newBtn(btnName);
                    button.Location = gridScale[i];

                    Point nLoc = new Point(x, y);
                    button.Click += (sender, e) => { Drop?.Invoke(new Point(nLoc.X, nLoc.Y)); };

                    Node node = new Node(x, y, button);
                    //nodes[i] = node;
                    nodes.Add(node);
                    this.Controls.Add(nodes[i].button);

                    i++;
                }
                ev++;
            }

            //Testing stuff
            //yell($"Button list length: {nodes.Length}\n\n{nodes[0].x}, {nodes[0].y}\n\n{nodes[1].x}, {nodes[1].y}");
        }

        ///
        public void InitNodes()
        {
            List<Button> buttons = new List<Button>();
            //Controls.CopyTo(buttons, 0);
            int px, py = 0;
            int i = 0;

            // sort buttons out of the controls in the form
            foreach (Control c in Controls)
            {
                if (c.Name.Contains("btn"))
                {
                    buttons.Add((Button)c);

                }
            }

            //Supposed to create nodes and link them to each button but its not currently working
            // past the first pass. Working on it.
            for (int y = 0; y < 7; y++)
            {
                py = y;
                for (int x = 0; x < 7; x++)
                {
                    px = x;
                    string btnname = "btn" + y.ToString() + x.ToString();

                    foreach (Button b in buttons)
                    {
                        if (b.Name == btnname)
                        {
                            Node node = new Node(x, y, b);
                            nodes[i] = node;
                            i++;
                        }
                    }

                    //x++;

                }

                //y++;

            }
            //Testing stuff
            //yell("Buttons list length:" + nodes.Length);
            //yell(nodes[0].button.Name + ":" + nodes[0].x.ToString() + "," + nodes[0].y.ToString());
            //yell(nodes[1].button.Name + ":" + nodes[1].x.ToString() + "," + nodes[1].y.ToString());
        }

        /// <summary>
        /// Reset a single specified button in the UI
        /// </summary>
        /// <param name="b">Button being reset</param>
        void ResetBtn(Button b) { b.BackgroundImage = Faces[0]; }

        void RmvBtn(Button b) { this.Controls.Remove(nodes[0].button); }
        /// <summary>
        /// Reset all buttons in the UI
        /// </summary>
        /// **Currently needs to be updated for new buttons**
        void ResetAllBtns()
        {
            foreach (Node n in nodes) {
                this.Controls.Remove(n.button);
            }
            nodes = new List<Node>();
            mockNodes();
        }
        /// <summary>
        /// Switch between players
        /// </summary>
        void playerTog()
        {
            if (activePlayer == 1) { activePlayer = 2; }
            else { activePlayer = 1; }
        }


        /// <summary>
        /// New game button: Resets the matrix and UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNG_Click(object sender, EventArgs e) { ResetAllBtns(); }

        /// <summary>
        /// Drops the activePlayers' peice into the board in a specified column.
        /// </summary>
        /// <param name="column"></param>
        void ColDrop(Point loc)
        {
            if (AI && activePlayer == 2) { }
            else
            {
                int ind;
                for (int i = 5; i >= 0; i--)
                {
                    ind = Node.Find(nodes, new Point(loc.X, i));
                    if (nodes[ind].player == 0)
                    {
                        nodes[ind].player = activePlayer;
                        nodes[ind].button.BackgroundImage = Faces[activePlayer];
                        CheckWinner(nodes[ind]);
                        playerTog();
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Checks matrix for winning patterns
        /// </summary>
        /// <param name="player">Player being checked</param>
        /// <returns>Is the specified player a Winner?</returns>
        bool isWinner(int player)
        {
            bool oP = false;

            WinCondition[] condition = new WinCondition[10];

            //Horizontal
            condition[0] = new WinCondition();
            condition[0].Add(0, 0);
            condition[0].Add(1, 0);
            condition[0].Add(2, 0);
            condition[0].Add(3, 0);

            condition[1] = new WinCondition();
            condition[1].Add(0, 1);
            condition[1].Add(1, 1);
            condition[1].Add(2, 1);
            condition[1].Add(3, 1);

            condition[2] = new WinCondition();
            condition[2].Add(0, 2);
            condition[2].Add(1, 2);
            condition[2].Add(2, 2);
            condition[2].Add(3, 2);

            condition[3] = new WinCondition();
            condition[3].Add(0, 3);
            condition[3].Add(1, 3);
            condition[3].Add(2, 3);
            condition[3].Add(3, 3);
            //Vertical
            condition[4] = new WinCondition();
            condition[4].Add(0, 0);
            condition[4].Add(0, 1);
            condition[4].Add(0, 2);
            condition[4].Add(0, 3);

            condition[5] = new WinCondition();
            condition[5].Add(1, 0);
            condition[5].Add(1, 1);
            condition[5].Add(1, 2);
            condition[5].Add(1, 3);

            condition[6] = new WinCondition();
            condition[6].Add(2, 0);
            condition[6].Add(2, 1);
            condition[6].Add(2, 2);
            condition[6].Add(2, 3);

            condition[7] = new WinCondition();
            condition[7].Add(3, 0);
            condition[7].Add(3, 1);
            condition[7].Add(3, 2);
            condition[7].Add(3, 3);
            //Diagonal
            condition[8] = new WinCondition();
            condition[8].Add(3, 3);
            condition[8].Add(2, 3);
            condition[8].Add(1, 3);
            condition[8].Add(0, 3);

            condition[9] = new WinCondition();
            condition[9].Add(0, 0);
            condition[9].Add(1, 0);
            condition[9].Add(2, 0);
            condition[9].Add(3, 0);

            //foreach (WinCondition c in condition)
            //{
            //    if (c.Confirmed(player, Slots))
            //    {
            //        oP = true;
            //        break;
            //    }
            //}
            return oP;
        }
        /// <summary>
        /// Determins the winning player
        /// </summary>
        /// <returns>Winning player number; Returns 0 if no winner is found</returns>
        int Winner()
        {
            if (isWinner(1)) { return 1; }
            if (isWinner(2)) { return 2; }
            return 0;
        }


        private void chkAI_CheckedChanged(object sender, EventArgs e) { AI = chkAI.Checked; }

        private void btnClose_Click(object sender, EventArgs e) { Application.Exit(); }

        public void CheckWinner(Node node)
        {
            CheckVertical(node);
            CheckHorizontal(node);
            CheckPosDiagonal(node);
            CheckNegDiagonal(node);
        }

        public void CheckVertical(Node node)
        {
            //Create list of possible winning nodes and add the dropped piece
            winNodes.Add(node);

            ///Check node north of current node, and all nodes above that
            CheckNorth(node);
            CheckSouth(node);
        
            if(winNodes.Count >= 4)
            {
                /// winner is active player
                Application.Exit();
            }
            else
            {
                //clear list if theres no winner
                winNodes.Clear();
            }

        }

        public void CheckNorth(Node node)
        {
            foreach (Node n in nodes)
            {
                if (n.x == node.x && n.y == node.y + 1)
                {
                    //check if it is the same color
                    if (n.button.BackgroundImage == Faces[activePlayer])
                    {
                        //add to possible winning nodes and check that piece
                        winNodes.Add(n);
                        CheckNorth(n);
                    }
                }
            }
        }
        public void CheckSouth(Node node) 
        {
            foreach (Node n in nodes)
            {
                if (n.x == node.x && n.y == node.y - 1)
                {
                    //check if it is the same color
                    if (n.button.BackgroundImage == Faces[activePlayer])
                    {
                        //add to possible winning nodes and check that piece
                        winNodes.Add(n);
                        CheckSouth(n);
                    }
                }
            }
        }

        public void CheckHorizontal(Node node)
        {
            //Create list of possible winning nodes and add the dropped piece
            winNodes.Add(node);

            ///Check nodes west and east of current node
            CheckWest(node);
            CheckEast(node);

            if (winNodes.Count >= 4)
            {
                /// winner is active player
                Application.Exit();
            }
            else
            {
                //clear list if theres no winner
                winNodes.Clear();
            }
        }

        public void CheckWest(Node node)
        {
            foreach (Node n in nodes)
            {
                if (n.x == node.x -1 && n.y == node.y)
                {
                    //check if it is the same color
                    if (n.button.BackgroundImage == Faces[activePlayer])
                    {
                        //add to possible winning nodes and check that piece
                        winNodes.Add(n);
                        CheckWest(n);
                    }
                }
            }
        }

        public void CheckEast(Node node)
        {
            foreach (Node n in nodes)
            {
                if (n.x == node.x + 1 && n.y == node.y)
                {
                    //check if it is the same color
                    if (n.button.BackgroundImage == Faces[activePlayer])
                    {
                        //add to possible winning nodes and check that piece
                        winNodes.Add(n);
                        CheckEast(n);
                    }
                }
            }
        }

        public void CheckPosDiagonal(Node node)
        {
            //Create list of possible winning nodes and add the dropped piece
            winNodes.Add(node);

            ///Check nodes west and east of current node
            CheckNorthEast(node);
            CheckSouthWest(node);

            if (winNodes.Count >= 4)
            {
                /// winner is active player
                Application.Exit();
            }
            else
            {
                //clear list if theres no winner
                winNodes.Clear();
            }
        }

        public void CheckNorthEast(Node node)
        {
            foreach (Node n in nodes)
            {
                if (n.x == node.x + 1 && n.y == node.y + 1)
                {
                    //check if it is the same color
                    if (n.button.BackgroundImage == Faces[activePlayer])
                    {
                        //add to possible winning nodes and check that piece
                        winNodes.Add(n);
                        CheckNorthEast(n);
                    }
                }
            }
        }

        public void CheckSouthWest(Node node)
        {
            foreach (Node n in nodes)
            {
                if (n.x == node.x - 1 && n.y == node.y - 1)
                {
                    //check if it is the same color
                    if (n.button.BackgroundImage == Faces[activePlayer])
                    {
                        //add to possible winning nodes and check that piece
                        winNodes.Add(n);
                        CheckSouthWest(n);
                    }
                }
            }
        }

        public void CheckNegDiagonal(Node node)
        {
            //Create list of possible winning nodes and add the dropped piece
            winNodes.Add(node);

            ///Check nodes west and east of current node
            CheckNorthWest(node);
            CheckSouthEast(node);

            if (winNodes.Count >= 4)
            {
                // winner is active player
                Application.Exit();
            }
            else
            {
                //clear list if theres no winner
                winNodes.Clear();
            }
        }

        public void CheckNorthWest(Node node)
        {
            foreach (Node n in nodes)
            {
                if (n.x == node.x - 1 && n.y == node.y + 1)
                {
                    //check if it is the same color
                    if (n.button.BackgroundImage == Faces[activePlayer])
                    {
                        //add to possible winning nodes and check that piece
                        winNodes.Add(n);
                        CheckNorthWest(n);
                    }
                }
            }
        }

        public void CheckSouthEast(Node node)
        {
            foreach (Node n in nodes)
            {
                if (n.x == node.x + 1 && n.y == node.y - 1)
                {
                    //check if it is the same color
                    if (n.button.BackgroundImage == Faces[activePlayer])
                    {
                        //add to possible winning nodes and check that piece
                        winNodes.Add(n);
                        CheckSouthEast(n);
                    }
                }
            }
        }

    }

    public class WinCondition
    {
        List<Point> positions = new List<Point>();
        public WinCondition()
        {

        }
        public void Add(int y, int x)
        {
            positions.Add(new Point(y, x));
        }
        public bool Confirmed(int player, int[,] matrix)
        {
            bool found = true;

            foreach (Point cord in positions)
            {
                if (matrix[cord.X, cord.Y] != player) { found = false; }
            }

            return found;
        }

    }

}
