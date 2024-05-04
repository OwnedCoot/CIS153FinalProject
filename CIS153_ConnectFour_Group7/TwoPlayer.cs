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

        // A string list to hold the moves made by the players
        // Has a size of 42 because there are 42 possible moves in Connect Four
        private List<string> moves = new List<string>(42);


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
            // Clear the moves list and write the moves to the moves file
            moves.Clear();
            GameUtilities.WriteMoves(moves);

            //Exits the application on click
            System.Environment.Exit(0);
        }

        // Logic for after a move is made
        private bool moveChecks()
        {
            // Check for a win
            if (board.CheckWin(curPlayer))
            {
                // Debug: Write the winning player to the console
                Console.WriteLine("Player " + curPlayer + " wins!");
                return false;
            }

            // Check for a draw (board is full)
            if (board.IsFull())
            {
                return false;
            }

            // If no win or draw, return true to continue the game
            return true;
        }
        
        // Given the column number, find the lowest empty cell and fill it with the current player's color
        private void column_Click(int c)
        {
            // Check if the column is full
            if (board.IsColumnFull(c))
            {
                // If the column is full, display a message and return
                lbl_Full.Text = $"Column {c + 1} is full!";
                return;
            }

            // If the column is not full, clear the full column message
            lbl_Full.Text = "";

            // Drop the piece in the column, save the move, write the move to the moves file, and switch players if the move is valid
            GameUtilities.DropPiece(board, c, curPlayer, moves);

            // Run the move checks after a move is made
            bool moveSuccess = moveChecks();

            // If the move was successful, run post-move operations
            if (moveSuccess)
            {
                // If no win or draw, switch players and continue the game
                curPlayer = GameUtilities.ChangePlayer(curPlayer);

                // Update the current player label
                lbl_CurrentPlayer.Text = "Player " + curPlayer + "'s turn";

                // Change the color of the current player label depending on the player
                if (curPlayer == 1)
                {
                    // Player 1 (Red)
                    lbl_CurrentPlayer.ForeColor = Color.Firebrick;
                }
                else
                {
                    // Player 2 (Yellow)
                    lbl_CurrentPlayer.ForeColor = Color.Goldenrod;
                }
            }

            // If the move was not successful, end the game
            else
            {
                // Check if a player won
                if (board.CheckWin(curPlayer))
                {
                    // Temp: Update the current player label to show the winning player
                    lbl_CurrentPlayer.Text = "Player " + curPlayer + " wins!";
                }

                // Check if the it was a draw
                else if (board.IsFull())
                {
                    // Temp: Update the current player label to show that it was a draw
                    lbl_CurrentPlayer.Text = "It's a draw!";
                }

                // Disable all column buttons
                column0.Enabled = false;
                column1.Enabled = false;
                column2.Enabled = false;
                column3.Enabled = false;
                column4.Enabled = false;
                column5.Enabled = false;
                column6.Enabled = false;
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

        // Format: tb_[row][column]

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
        //    Color Blue = Color.FromArgb(255, 0, 0);
        //    Pen BluePen = new Pen(Blue);
        //    BluePen.Width = 25;
        //    e.Graphics.DrawEllipse(Pens.Blue, 400, 150, 400, 400);
        //}
        
    }
}
