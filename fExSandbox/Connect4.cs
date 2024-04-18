using fExSandbox.Properties;
using System.Security.Cryptography.X509Certificates;

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
        Node[] nodes = new Node[42];
        //Matrix Holding player dot positions
        int[,] Slots = new int[4, 4];

        //Event Handling
        public delegate void dropHandler(int col);
        public event dropHandler? Drop;

        public Delegate[] moveset = new Delegate[7];
        public event EventHandler cHandle;

        /*UI*/
        public List<Point> gridScale = new List<Point>();

        /*Controls*/
        List<Button> btns = new List<Button>();

        public Connect4()
        {
            InitializeComponent();
            initMoveset();

            //InitNodes();
            mockNodes();

        }
        public void initMoveset()
        {
            Drop += mockCDrop;
        }

        /// <summary>
        /// Test Grid generation
        /// </summary>
        void gridTest()
        {
            Button[] nGrid = newGrid();

            for (int i = 0; i < 42; i++)
            {
                this.Controls.Add(nGrid[i]);
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

        public Button[] newGrid()
        {
            List<Button> grid = new List<Button>();

            for (int i = 0; i < 42; i++)
            {
                Button spawn = newBtn("btn" + i);
                spawn.Location = gridScale[i];
                grid.Add(spawn);
            }

            return grid.ToArray();
        }

        private void Connect4_Load(object sender, EventArgs e)
        {


            //Load Movesets for AI interactions
            moveset[0] = () => { ColDrop(1); };
            moveset[1] = () => { ColDrop(2); };
            moveset[2] = () => { ColDrop(3); };
            moveset[3] = () => { ColDrop(4); };
        }
        /// <summary>
        /// Print a string to the display
        /// </summary>
        /// <param name="inp">Input string</param>
        public void yell(string inp) { txtDisp.Text = inp; }


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

                    yell($"{x}, {y}");
                    string btnName = "btn" + y.ToString() + x.ToString();
                    Button button = newBtn(btnName);
                    button.Location = gridScale[i];

                    button.Click += (sender, e)=> { Drop?.Invoke(x); };

                    Node node = new Node(x, y, button);
                    nodes[i] = node;
                    this.Controls.Add(nodes[i].button);

                    i++;
                }
                ev++;
            }

            //Testing stuff
            //yell("Buttons list length:" + nodes.Length);
            //yell(nodes[0].button.Name + ":" + nodes[0].x.ToString() + "," + nodes[0].y.ToString());
            //yell(nodes[1].button.Name + ":" + nodes[1].x.ToString() + "," + nodes[1].y.ToString());
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

        void RmvBtn(Button b)
        {
            this.Controls.Remove(nodes[0].button);
        }
        /// <summary>
        /// Reset all buttons in the UI
        /// </summary>
        /// **Currently needs to be updated for new buttons**
        void ResetAllBtns()
        {
            for (int i = 0; i <= nodes.Length; i++)
            {
                RmvBtn(nodes[i].button);
            }
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
        private void btnNG_Click(object sender, EventArgs e)
        {
            ResetAllBtns();
        }
        /// <summary>
        /// Drops the activePlayers' peice into the board in a specified column.
        /// </summary>
        /// <param name="column"></param>
        void ColDrop(int column)
        {
            if (Winner() == 0)
            {
                int aCol = column - 1;

                for (int i = 3; i >= 0; i--)
                {
                    if (Slots[i, aCol] > 0)
                    {
                        txtDisp.Text += "-filled-";
                    }
                    else
                    {
                        Slots[i, aCol] = activePlayer;
                        break;
                    }
                }
                if (!isWinner(activePlayer))
                {
                    playerTog();
                    txtDisp.Text = "Player " + activePlayer + "s Turn!";
                }
                else { txtDisp.Text = "Player " + activePlayer + "Wins!"; }
                //UpdDisplay();
            }
        }

        void mockCDrop(int col)
        {
            int i = 0;
            int x = col;
            int y = 6;

            for (int j = 6; j > 0; j--)
            {
                i = x + (y * 7);
                if (nodes[i].player == 0)
                {
                    yell("yoop");
                    nodes[i].player = activePlayer; //update player ownership
                    nodes[i].button.BackgroundImage = Faces[activePlayer];  //update button image
                    break;
                }
                y--;
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

            foreach (WinCondition c in condition)
            {
                if (c.Confirmed(player, Slots))
                {
                    oP = true;
                    break;
                }
            }
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

        private void col1Click(object sender, EventArgs e)
        {
            mockCDrop(1);
        }
        private void col2Click(object sender, EventArgs e)
        {
            mockCDrop(2);
        }
        private void col3Click(object sender, EventArgs e)
        {
            mockCDrop(3);
        }
        private void col4Click(object sender, EventArgs e)
        {
            mockCDrop(4);
        }

        private void chkAI_CheckedChanged(object sender, EventArgs e)
        {
            AI = chkAI.Checked;
        }

        private void txtDisp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHoverCancel(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Transparent;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form abt = new abtBox();
            abt.ShowDialog();
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
