using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fExSandbox
{
    public partial class Connect4 : Form
    {
        public bool AI = false;
        //Images for player pieces in order [Empty, Player 1, Player 2]
        Bitmap[] Faces = new Bitmap[3] { Properties.Resources.hole_Empty__01, Properties.Resources.hole_fill__01, Properties.Resources.hole_fill__02_01 };

        //Matrix Holding player dot positions
        int[,] Slots = new int[4, 4];
        //Current player's turn
        int activePlayer = 1;

        public Delegate[] moveset = new Delegate[4];

        private void Connect4_Load(object sender, EventArgs e)
        {
            //Load Movesets for AI interactions
            moveset[0] = () => { ColDrop(1); };
            moveset[1] = () => { ColDrop(2); };
            moveset[2] = () => { ColDrop(3); };
            moveset[3] = () => { ColDrop(4); };

        }


        /// <summary>
        /// Reset a single specified button in the UI
        /// </summary>
        /// <param name="b">Button being reset</param>
        void ResetBtn(Button b) { b.BackgroundImage = Faces[0]; }
        /// <summary>
        /// Reset all buttons in the UI
        /// </summary>
        void ResetAllBtns()
        {
            ResetBtn(btn1);
            ResetBtn(btn2);
            ResetBtn(btn3);
            ResetBtn(btn4);
            ResetBtn(btn5);
            ResetBtn(btn6);
            ResetBtn(btn7);
            ResetBtn(btn8);
            ResetBtn(btn9);
            ResetBtn(btn10);
            ResetBtn(btn11);
            ResetBtn(btn12);
            ResetBtn(btn13);
            ResetBtn(btn14);
            ResetBtn(btn15);
            ResetBtn(btn16);
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
        /// Update the UI to reflect the current dot matrix
        /// </summary>
        void UpdDisplay()
        {
            btn1.BackgroundImage = Faces[Slots[0, 0]];
            btn2.BackgroundImage = Faces[Slots[0, 1]];
            btn3.BackgroundImage = Faces[Slots[0, 2]];
            btn4.BackgroundImage = Faces[Slots[0, 3]];
            btn5.BackgroundImage = Faces[Slots[1, 0]];
            btn6.BackgroundImage = Faces[Slots[1, 1]];
            btn7.BackgroundImage = Faces[Slots[1, 2]];
            btn8.BackgroundImage = Faces[Slots[1, 3]];
            btn9.BackgroundImage = Faces[Slots[2, 0]];
            btn10.BackgroundImage = Faces[Slots[2, 1]];
            btn11.BackgroundImage = Faces[Slots[2, 2]];
            btn12.BackgroundImage = Faces[Slots[2, 3]];
            btn13.BackgroundImage = Faces[Slots[3, 0]];
            btn14.BackgroundImage = Faces[Slots[3, 1]];
            btn15.BackgroundImage = Faces[Slots[3, 2]];
            btn16.BackgroundImage = Faces[Slots[3, 3]];
        }

        public Connect4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// New game button: Resets the matrix and UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNG_Click(object sender, EventArgs e)
        {
            //Reset Dot Matrix
            Slots = new int[4, 4];
            //Reset Display
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
                UpdDisplay();
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
            ColDrop(1);
        }
        private void col2Click(object sender, EventArgs e)
        {
            ColDrop(2);
        }
        private void col3Click(object sender, EventArgs e)
        {
            ColDrop(3);
        }
        private void col4Click(object sender, EventArgs e)
        {
            ColDrop(4);
        }

        private void chkAI_CheckedChanged(object sender, EventArgs e)
        {
            AI = chkAI.Checked;
        }
    }

    public class WinCondition
    {
        List<intVec2> positions = new List<intVec2>();
        public WinCondition()
        {

        }
        public void Add(int y, int x)
        {
            positions.Add(new intVec2(y, x));
        }
        public bool Confirmed(int player, int[,] matrix)
        {
            bool found = true;

            foreach (intVec2 cord in positions)
            { 
                if (matrix[cord.X, cord.Y] != player) { found = false; }
            }

            return found;
        }

        public class intVec2 { 
            public int X = 0;
            public int Y = 0;
            public intVec2() { }
            public intVec2(int x, int y) { X = x; Y = y; }
        }
    }
}
