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
    public partial class OnePlayer : Form
    {
        form_TitleScreen pform;

        //TextBox array for one-Player mode
        private TextBox[,] onePlayerTBA = new TextBox[6, 7];

        private Board board;

        private Computer ai = new Computer();

        private bool gameOver = false;

        // Current player
        private int curPlayer = 1;

        // A string list to hold the moves made by the players
        // Has a size of 42 because there are 42 possible moves in Connect Four
        private List<string> moves = new List<string>(42);

        //==========CONSTRUCTORS==========
        public OnePlayer()
        {
            InitializeComponent();
        }

        //overloaded constructor
        public OnePlayer(form_TitleScreen pf)
        {
            InitializeComponent();
            //this passes the parent form to this form so we can get back to it.
            pform = pf;
            InitializeTextBoxes();
            // Create the game board
            board = new Board(onePlayerTBA);
        }

        //==========BUTTON CLICKS==========
        private void btn_quit3_Click(object sender, EventArgs e)
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
            if (gameOver != true)
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
                        gameOver = true;
                    }

                    // Check if the it was a draw
                    else if (board.IsFull())
                    {
                        // Temp: Update the current player label to show that it was a draw
                        lbl_CurrentPlayer.Text = "It's a draw!";
                        gameOver = true;
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
                if (gameOver != true)
                {
                    ai.MakeMove(board, moves);
                }

                // Run the move checks after a move is made
                moveSuccess = moveChecks();

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
                        gameOver = true;
                    }

                    // Check if the it was a draw
                    else if (board.IsFull())
                    {
                        // Temp: Update the current player label to show that it was a draw
                        lbl_CurrentPlayer.Text = "It's a draw!";
                        gameOver = true;
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

                //curPlayer = GameUtilities.ChangePlayer(curPlayer);
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



        private void column1Click(object sender, EventArgs e)
        {
            column_Click(0);
        }
        private void column2Click(object sender, EventArgs e)
        {
            column_Click(1);
        }
        private void column3Click(object sender, EventArgs e)
        {
            column_Click(2);
        }
        private void column4Click(object sender, EventArgs e)
        {
            column_Click(3);
        }
        private void column5Click(object sender, EventArgs e)
        {
            column_Click(4);
        }
        private void column6Click(object sender, EventArgs e)
        {
            column_Click(5);
        }
        private void column7Click(object sender, EventArgs e)
        {
            column_Click(6);
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
            onePlayerTBA[0, 0] = tb_00;
            onePlayerTBA[0, 1] = tb_01;
            onePlayerTBA[0, 2] = tb_02;
            onePlayerTBA[0, 3] = tb_03;
            onePlayerTBA[0, 4] = tb_04;
            onePlayerTBA[0, 5] = tb_05;
            onePlayerTBA[0, 6] = tb_06;

            // Row 2
            onePlayerTBA[1, 0] = tb_10;
            onePlayerTBA[1, 1] = tb_11;
            onePlayerTBA[1, 2] = tb_12;
            onePlayerTBA[1, 3] = tb_13;
            onePlayerTBA[1, 4] = tb_14;
            onePlayerTBA[1, 5] = tb_15;
            onePlayerTBA[1, 6] = tb_16;

            // Row 3
            onePlayerTBA[2, 0] = tb_20;
            onePlayerTBA[2, 1] = tb_21;
            onePlayerTBA[2, 2] = tb_22;
            onePlayerTBA[2, 3] = tb_23;
            onePlayerTBA[2, 4] = tb_24;
            onePlayerTBA[2, 5] = tb_25;
            onePlayerTBA[2, 6] = tb_26;

            // Row 4
            onePlayerTBA[3, 0] = tb_30;
            onePlayerTBA[3, 1] = tb_31;
            onePlayerTBA[3, 2] = tb_32;
            onePlayerTBA[3, 3] = tb_33;
            onePlayerTBA[3, 4] = tb_34;
            onePlayerTBA[3, 5] = tb_35;
            onePlayerTBA[3, 6] = tb_36;

            // Row 5
            onePlayerTBA[4, 0] = tb_40;
            onePlayerTBA[4, 1] = tb_41;
            onePlayerTBA[4, 2] = tb_42;
            onePlayerTBA[4, 3] = tb_43;
            onePlayerTBA[4, 4] = tb_44;
            onePlayerTBA[4, 5] = tb_45;
            onePlayerTBA[4, 6] = tb_46;

            // Row 6
            onePlayerTBA[5, 0] = tb_50;
            onePlayerTBA[5, 1] = tb_51;
            onePlayerTBA[5, 2] = tb_52;
            onePlayerTBA[5, 3] = tb_53;
            onePlayerTBA[5, 4] = tb_54;
            onePlayerTBA[5, 5] = tb_55;
            onePlayerTBA[5, 6] = tb_56;
        }


        //===============================================================
        //  MOUSE HOVER AND EXIT FUNCTIONS
        //===============================================================
        private void Column1MouseHover(object sender, EventArgs e)
        {
            if (gameOver != true)
            {
                // Find the lowest empty cell in column 1
                for (int i = 5; i >= 0; i--)
                {
                    // Check if the cell in row i is empty
                    if (board.GetCell(i, 0).GetPlayer() == 0)
                    {
                        // Temporarily set the cell to the current player to visualize the ghost piece
                        board.GetCell(i, 0).SetPlayer(curPlayer);

                        // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                        board.ChangeGhostPeice(i, 0);

                        // Refresh the UI to display the ghost piece
                        Refresh();

                        // Restore the original state of the cell after visualization
                        board.GetCell(i, 0).SetPlayer(0);

                        break;
                    }
                }
            }
        }

        private void Column1MouseLeave(object sender, EventArgs e)
        {
            for (int i = 5; i >= 0; i--)
            {
                // Check if the cell in row i is empty
                if (board.GetCell(i, 0).GetPlayer() == 0)
                {
                    // Temporarily set the cell to the current player to visualize the ghost piece
                    board.GetCell(i, 0).SetPlayer(curPlayer);

                    // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                    board.ChangeToDefaultColor(i, 0);

                    // Refresh the UI to display the ghost piece
                    Refresh();

                    // Restore the original state of the cell after visualization
                    board.GetCell(i, 0).SetPlayer(0);

                    break;
                }
            }

        }

        private void Column2MouseHover(object sender, EventArgs e)
        {
            if (gameOver != true)
            {
                // Find the lowest empty cell in column 1
                for (int i = 5; i >= 0; i--)
                {
                    // Check if the cell in row i is empty
                    if (board.GetCell(i, 1).GetPlayer() == 0)
                    {
                        // Temporarily set the cell to the current player to visualize the ghost piece
                        board.GetCell(i, 1).SetPlayer(curPlayer);

                        // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                        board.ChangeGhostPeice(i, 1);

                        // Refresh the UI to display the ghost piece
                        Refresh();

                        // Restore the original state of the cell after visualization
                        board.GetCell(i, 1).SetPlayer(0);

                        break;
                    }
                }
            }
        }

        private void Column2MouseLeave(object sender, EventArgs e)
        {
            for (int i = 5; i >= 0; i--)
            {
                // Check if the cell in row i is empty
                if (board.GetCell(i, 1).GetPlayer() == 0)
                {
                    // Temporarily set the cell to the current player to visualize the ghost piece
                    board.GetCell(i, 1).SetPlayer(curPlayer);

                    // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                    board.ChangeToDefaultColor(i, 1);

                    // Refresh the UI to display the ghost piece
                    Refresh();

                    // Restore the original state of the cell after visualization
                    board.GetCell(i, 1).SetPlayer(0);

                    break;
                }
            }

        }

        private void Column3MouseHover(object sender, EventArgs e)
        {
            if (gameOver != true)
            {
                // Find the lowest empty cell in column 1
                for (int i = 5; i >= 0; i--)
                {
                    // Check if the cell in row i is empty
                    if (board.GetCell(i, 2).GetPlayer() == 0)
                    {
                        // Temporarily set the cell to the current player to visualize the ghost piece
                        board.GetCell(i, 2).SetPlayer(curPlayer);

                        // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                        board.ChangeGhostPeice(i, 2);

                        // Refresh the UI to display the ghost piece
                        Refresh();

                        // Restore the original state of the cell after visualization
                        board.GetCell(i, 2).SetPlayer(0);

                        break;
                    }
                }
            }
        }

        private void Column3MouseLeave(object sender, EventArgs e)
        {
            for (int i = 5; i >= 0; i--)
            {
                // Check if the cell in row i is empty
                if (board.GetCell(i, 2).GetPlayer() == 0)
                {
                    // Temporarily set the cell to the current player to visualize the ghost piece
                    board.GetCell(i, 2).SetPlayer(curPlayer);

                    // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                    board.ChangeToDefaultColor(i, 2);

                    // Refresh the UI to display the ghost piece
                    Refresh();

                    // Restore the original state of the cell after visualization
                    board.GetCell(i, 2).SetPlayer(0);

                    break;
                }
            }

        }

        private void Column4MouseHover(object sender, EventArgs e)
        {
            if (gameOver != true)
            {
                // Find the lowest empty cell in column 1
                for (int i = 5; i >= 0; i--)
                {
                    // Check if the cell in row i is empty
                    if (board.GetCell(i, 3).GetPlayer() == 0)
                    {
                        // Temporarily set the cell to the current player to visualize the ghost piece
                        board.GetCell(i, 3).SetPlayer(curPlayer);

                        // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                        board.ChangeGhostPeice(i, 3);

                        // Refresh the UI to display the ghost piece
                        Refresh();

                        // Restore the original state of the cell after visualization
                        board.GetCell(i, 3).SetPlayer(0);

                        break;
                    }
                }
            }
        }

        private void Column4MouseLeave(object sender, EventArgs e)
        {
            for (int i = 5; i >= 0; i--)
            {
                // Check if the cell in row i is empty
                if (board.GetCell(i, 3).GetPlayer() == 0)
                {
                    // Temporarily set the cell to the current player to visualize the ghost piece
                    board.GetCell(i, 3).SetPlayer(curPlayer);

                    // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                    board.ChangeToDefaultColor(i, 3);

                    // Refresh the UI to display the ghost piece
                    Refresh();

                    // Restore the original state of the cell after visualization
                    board.GetCell(i, 3).SetPlayer(0);

                    break;
                }
            }

        }

        private void Column5MouseHover(object sender, EventArgs e)
        {
            if (gameOver != true)
            {
                // Find the lowest empty cell in column 1
                for (int i = 5; i >= 0; i--)
                {
                    // Check if the cell in row i is empty
                    if (board.GetCell(i, 4).GetPlayer() == 0)
                    {
                        // Temporarily set the cell to the current player to visualize the ghost piece
                        board.GetCell(i, 4).SetPlayer(curPlayer);

                        // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                        board.ChangeGhostPeice(i, 4);

                        // Refresh the UI to display the ghost piece
                        Refresh();

                        // Restore the original state of the cell after visualization
                        board.GetCell(i, 4).SetPlayer(0);

                        break;
                    }
                }
            }
        }

        private void Column5MouseLeave(object sender, EventArgs e)
        {
            for (int i = 5; i >= 0; i--)
            {
                // Check if the cell in row i is empty
                if (board.GetCell(i, 4).GetPlayer() == 0)
                {
                    // Temporarily set the cell to the current player to visualize the ghost piece
                    board.GetCell(i, 4).SetPlayer(curPlayer);

                    // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                    board.ChangeToDefaultColor(i, 4);

                    // Refresh the UI to display the ghost piece
                    Refresh();

                    // Restore the original state of the cell after visualization
                    board.GetCell(i, 4).SetPlayer(0);

                    break;
                }
            }

        }

        private void Column6MouseHover(object sender, EventArgs e)
        {
            if (gameOver != true)
            {
                // Find the lowest empty cell in column 1
                for (int i = 5; i >= 0; i--)
                {
                    // Check if the cell in row i is empty
                    if (board.GetCell(i, 5).GetPlayer() == 0)
                    {
                        // Temporarily set the cell to the current player to visualize the ghost piece
                        board.GetCell(i, 5).SetPlayer(curPlayer);

                        // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                        board.ChangeGhostPeice(i, 5);

                        // Refresh the UI to display the ghost piece
                        Refresh();

                        // Restore the original state of the cell after visualization
                        board.GetCell(i, 5).SetPlayer(0);

                        break;
                    }
                }
            }
        }

        private void Column6MouseLeave(object sender, EventArgs e)
        {
            for (int i = 5; i >= 0; i--)
            {
                // Check if the cell in row i is empty
                if (board.GetCell(i, 5).GetPlayer() == 0)
                {
                    // Temporarily set the cell to the current player to visualize the ghost piece
                    board.GetCell(i, 5).SetPlayer(curPlayer);

                    // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                    board.ChangeToDefaultColor(i, 5);

                    // Refresh the UI to display the ghost piece
                    Refresh();

                    // Restore the original state of the cell after visualization
                    board.GetCell(i, 5).SetPlayer(0);

                    break;
                }
            }

        }

        private void Column7MouseHover(object sender, EventArgs e)
        {
            if (gameOver != true)
            {
                // Find the lowest empty cell in column 1
                for (int i = 5; i >= 0; i--)
                {
                    // Check if the cell in row i is empty
                    if (board.GetCell(i, 6).GetPlayer() == 0)
                    {
                        // Temporarily set the cell to the current player to visualize the ghost piece
                        board.GetCell(i, 6).SetPlayer(curPlayer);

                        // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                        board.ChangeGhostPeice(i, 6);

                        // Refresh the UI to display the ghost piece
                        Refresh();

                        // Restore the original state of the cell after visualization
                        board.GetCell(i, 6).SetPlayer(0);

                        break;
                    }
                }
            }
        }

        private void Column7MouseLeave(object sender, EventArgs e)
        {
            for (int i = 5; i >= 0; i--)
            {
                // Check if the cell in row i is empty
                if (board.GetCell(i, 6).GetPlayer() == 0)
                {
                    // Temporarily set the cell to the current player to visualize the ghost piece
                    board.GetCell(i, 6).SetPlayer(curPlayer);

                    // -- Code for changing the color of the button overlay goes here (For when we switch to buttons) --
                    board.ChangeToDefaultColor(i, 6);

                    // Refresh the UI to display the ghost piece
                    Refresh();

                    // Restore the original state of the cell after visualization
                    board.GetCell(i, 6).SetPlayer(0);

                    break;
                }
            }

        }

    }
}
