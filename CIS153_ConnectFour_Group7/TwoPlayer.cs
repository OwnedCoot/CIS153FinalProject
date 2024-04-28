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

        // Create the game board
        private Board board = new Board();

        // Current player
        private int curPlayer = 1;

        //==========CONSTRUCTORS==========
        public TwoPlayer()
        {
            InitializeComponent();
        }

        //overloaded constructor
        public TwoPlayer(form_TitleScreen pf)
        {
            InitializeComponent();
            //this passes the parent form to this form so we can get back to it.
            pform = pf;
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
