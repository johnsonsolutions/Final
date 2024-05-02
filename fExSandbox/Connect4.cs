using fExSandbox.Properties;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace fExSandbox
{
    public partial class Connect4 : Form
    {
        /*Preferences*/
        public bool AI = false;
        public int AICol;
        //Images for player pieces in order [Empty, Player 1, Player 2]
        Bitmap[] Faces = new Bitmap[3] { Properties.Resources.t1_01, Properties.Resources.t2_01, Properties.Resources.t3_01 };

        /*Data*/
        //Current player's turn
        int activePlayer = 1;
        Node gameState = new Node();
        //List<Slot> gameState.state = new List<Slot>();

        // possible winning nodes
        List<Slot> winNodes = new List<Slot>();


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
            Drop += ColDrop;

            InitNodes();
        }

        void nodeTest()
        {
            for (int i = 0; i < gameState.state.Count; i++)
            {
                yell($"Node {i}:\n - Location: ({gameState.state[i].x}, {gameState.state[i].y})");
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
        public void InitNodes()
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

                    Slot node = new Slot(x, y, button);
                    //nodes[i] = node;
                    gameState.state.Add(node);
                    this.Controls.Add(gameState.state[i].button);

                    i++;
                }
                ev++;
            }

            //Testing stuff
            //yell($"Button list length: {nodes.Length}\n\n{nodes[0].x}, {nodes[0].y}\n\n{nodes[1].x}, {nodes[1].y}");
        }


        /// <summary>
        /// Reset a single specified button in the UI
        /// </summary>
        /// <param name="b">Button being reset</param>
        void ResetBtn(Button b) { b.BackgroundImage = Faces[0]; }

        void RmvBtn(Button b) { this.Controls.Remove(gameState.state[0].button); }
        /// <summary>
        /// Reset all buttons in the UI
        /// </summary>
        /// **Currently needs to be updated for new buttons**
        void ResetAllBtns()
        {
            foreach (Slot n in gameState.state) {
                this.Controls.Remove(n.button);
            }
            gameState.state = new List<Slot>();
            activePlayer = 1;
            InitNodes();
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
            if (AI )//&& activePlayer == 2)
            {
                //algorithmCol(AICol);
                int ind;
                for (int i = 5; i >= 0; i--)
                {
                    ind = Slot.Find(gameState.state, new Point(loc.X, i));
                    if (gameState.state[ind].player == 0)
                    {
                        gameState.state[ind].player = activePlayer;
                        gameState.state[ind].button.BackgroundImage = Faces[activePlayer];
                        CheckWinner(gameState.state[ind]);
                        AITurn();
                        return;
                    }
                }
            }
            else
            {
                int ind;
                for (int i = 5; i >= 0; i--)
                {
                    ind = Slot.Find(gameState.state, new Point(loc.X, i));
                    if (gameState.state[ind].player == 0)
                    {
                        gameState.state[ind].player = activePlayer;
                        gameState.state[ind].button.BackgroundImage = Faces[activePlayer];
                        CheckWinner(gameState.state[ind]);
                        playerTog();
                        return;
                    }
                }
            }
        }

        void AITurn()
        {
            if (activePlayer == 1)
            {
                playerTog();
                

                algorithmCol();

                int ind;
                for (int i = 5; i >= 0; i--)
                {
                    ind = Slot.Find(gameState.state, new Point(AICol, i));
                    if (gameState.state[ind].player == 0)
                    {
                        gameState.state[ind].player = activePlayer;
                        gameState.state[ind].button.BackgroundImage = Faces[activePlayer];
                        CheckWinner(gameState.state[ind]);
                        playerTog();
                        return;
                    }
                }
            }
            
        }
        public void algorithmCol() 
        {
            if (AICol < 6)          //if-else statement is temp for testing
            {
                AICol = AICol + 1;
            }
            else
            {
                AICol = 0;
            }
        }


        /// <summary>
        /// Determins the winning player
        /// </summary>
        /// <returns>Winning player number; Returns 0 if no winner is found</returns>


        private void chkAI_CheckedChanged(object sender, EventArgs e) { AI = chkAI.Checked; }

        private void btnClose_Click(object sender, EventArgs e) { Application.Exit(); }

        public void CheckWinner(Slot node)
        {
            node.CheckVertical(node, gameState);
            node.CheckHorizontal(node, gameState);
            node.CheckPosDiagonal(node, gameState);
            node.CheckNegDiagonal(node, gameState);
        }


    }

}
