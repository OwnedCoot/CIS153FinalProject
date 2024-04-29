using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_ConnectFour_Group7
{
    public partial class TwoPlayer : Form
    {
        form_TitleScreen pform;

        //TextBox array for Two-Player mode
        private TextBox[,] twoPlayerTBA = new TextBox[6, 7];

        private Board board;

        // Current player
        private int curPlayer = 1;




        //==========CONSTRUCTORS==========

        //overloaded constructor
        public TwoPlayer(form_TitleScreen pf)
        {
            InitializeComponent();
            //this passes the parent form to this form so we can get back to it.
            pform = pf;
            InitializeTextBoxes();
            // Create the game board
            board = new Board(twoPlayerTBA);
        }

        //==========BUTTON CLICKS==========
        private void btn_quit1_Click(object sender, EventArgs e)
        {
            //Exits the application on click
            System.Environment.Exit(0);
        }

        // Logic for after a move is made
        private int moveChecks()
        {
            /* return 1 = the current player has won
             * return 2 = the board is full (draw)
             * return 0 = the game continues
             */ 

            // Check for a win
            if (board.CheckWin(curPlayer))
            {
                return 1;
            }

            // Check for a draw (board is full)
            if (board.IsFull())
            {
                return 2;
            }

            // If no win or draw, switch players and continue the game
            GameUtilities.ChangePlayer(curPlayer);
            return 0;
        }
        
        // Given the column number, find the lowest empty cell and fill it with the current player's color
        private void column_Click(int c)
        {
            // Find the lowest empty cell in column 1
            for (int i = 5; i >= 0; i--)
            {
                // Check if the cell in row i is empty
                if (board.GetCell(i, c).GetPlayer() == 0)
                {
                    // Set the cell to the current player
                    board.GetCell(i, c).SetPlayer(curPlayer);

                    // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                    board.ChangeColor(i, c);

                    // change the player ***I think this should be somewhere else but I am putting it
                    // here for testing purposes***

                    if (curPlayer == 1)
                    {
                        //change from P1 to P2
                        curPlayer = 2;
                    }
                    else if (curPlayer == 2)
                    {
                        //change from P2 to P1
                        curPlayer = 1;
                    }

                    break;
                }
            }

            // Run the move checks after a move is made
            int result = moveChecks();

            switch (result)
            {
                case 1:
                {
                    // -- Code for end game win goes here --
                    
                    break;
                }

                case 2:
                {
                    // -- Code for end game draw goes here --

                    break;
                }

                case 0:
                {
                    // Continue the game
                    break;
                }
            }
        }

        // Get the column number from whichever column button was clicked and call column_Click
        private void getColumn(object sender, EventArgs e)
        {
            // Save which button was clicked to a Button object using the sender object
            Button colButton = (Button)sender;

            // Get the name of the button
            string btnName = colButton.Name;

            // Extract the column number from the button name and convert it to its integer value equivalent
            int colNum = int.Parse(btnName.Substring(6));

            // Call the column_Click method with the column number
            column_Click(colNum);
        }


        //========================
        // 2D array of TextBoxes
        //========================
        // Initialize the 2D array of text boxes.
        // Because the text boxes are pre-placed, I am just going to assign their names to each element
        // in the 2D array instead of make code that creates new text boxes.

        private void InitializeTextBoxes()
        {
            // Row 1
            twoPlayerTBA[0, 0] = tb_00;
            twoPlayerTBA[0, 1] = tb_01;
            twoPlayerTBA[0, 2] = tb_02;
            twoPlayerTBA[0, 3] = tb_03;
            twoPlayerTBA[0, 4] = tb_04;
            twoPlayerTBA[0, 5] = tb_05;
            twoPlayerTBA[0, 6] = tb_06;

            // Row 2
            twoPlayerTBA[1, 0] = tb_10;
            twoPlayerTBA[1, 1] = tb_11;
            twoPlayerTBA[1, 2] = tb_12;
            twoPlayerTBA[1, 3] = tb_13;
            twoPlayerTBA[1, 4] = tb_14;
            twoPlayerTBA[1, 5] = tb_15;
            twoPlayerTBA[1, 6] = tb_16;

            // Row 3
            twoPlayerTBA[2, 0] = tb_20;
            twoPlayerTBA[2, 1] = tb_21;
            twoPlayerTBA[2, 2] = tb_22;
            twoPlayerTBA[2, 3] = tb_23;
            twoPlayerTBA[2, 4] = tb_24;
            twoPlayerTBA[2, 5] = tb_25;
            twoPlayerTBA[2, 6] = tb_26;

            // Row 4
            twoPlayerTBA[3, 0] = tb_30;
            twoPlayerTBA[3, 1] = tb_31;
            twoPlayerTBA[3, 2] = tb_32;
            twoPlayerTBA[3, 3] = tb_33;
            twoPlayerTBA[3, 4] = tb_34;
            twoPlayerTBA[3, 5] = tb_35;
            twoPlayerTBA[3, 6] = tb_36;

            // Row 5
            twoPlayerTBA[4, 0] = tb_40;
            twoPlayerTBA[4, 1] = tb_41;
            twoPlayerTBA[4, 2] = tb_42;
            twoPlayerTBA[4, 3] = tb_43;
            twoPlayerTBA[4, 4] = tb_44;
            twoPlayerTBA[4, 5] = tb_45;
            twoPlayerTBA[4, 6] = tb_46;

            // Row 6
            twoPlayerTBA[5, 0] = tb_50;
            twoPlayerTBA[5, 1] = tb_51;
            twoPlayerTBA[5, 2] = tb_52;
            twoPlayerTBA[5, 3] = tb_53;
            twoPlayerTBA[5, 4] = tb_54;
            twoPlayerTBA[5, 5] = tb_55;
            twoPlayerTBA[5, 6] = tb_56;
        }

        //Testing for making transparent
        //private void column1_Click(object sender, EventArgs e)
        //{
        //    Bitmap bitmap0 = new Bitmap(pictureBox1.Image);
        //    var bt = MakeTransparent(bitmap0, Color.White, 30);
        //    pictureBox1.Image = bt;
        //}
        //private Bitmap MakeTransparent(Bitmap bitmap, Color color, int tolerance)
        //{
        //    Bitmap transparentImage = new Bitmap(bitmap);

        //    for (int i = transparentImage.Size.Width - 1; i >= 0; i--)
        //    {
        //        for (int j = transparentImage.Size.Height - 1; j >= 0; j--)
        //        {
        //            var currentColor = transparentImage.GetPixel(i, j);
        //            if (Math.Abs(color.R - currentColor.R) < tolerance &&
        //              Math.Abs(color.G - currentColor.G) < tolerance &&
        //              Math.Abs(color.B - currentColor.B) < tolerance)
        //                transparentImage.SetPixel(i, j, color);
        //        }
        //    }

        //    transparentImage.MakeTransparent(color);
        //    return transparentImage;
        //}

        //this was the the leftover basic code for pen to draw objects, left it here in case we wanted to revist the idea feel free to delet if you wish
        //private void TwoPlayer_Paint(object sender, PaintEventArgs e)
        //{
        //    Color Blue = Color.FromArgb(0,0,255);
        //    Pen BluePen = new Pen(Blue);
        //}
    }
}
