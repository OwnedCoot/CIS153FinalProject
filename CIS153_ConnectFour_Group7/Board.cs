using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace CIS153_ConnectFour_Group7
{
    internal class Board
    {
        private const int rows = 6;
        private const int columns = 7;

        // Creates a 2D array of Cells in the format [row, column]
        private Cell[,] board;

        private TextBox[,] textBoxes;
        // ========================================================================
        //                                  Getters
        // ========================================================================
        public int GetRows()
        {
            return rows;
        }

        public int GetColumns()
        {
            return columns;
        }

        // r = row, c = column
        public Cell GetCell(int r, int c)
        {
            return board[r, c];
        }

        // ========================================================================
        //                                  Setters
        // ========================================================================

        //Commented these out as rows and columns are constant and will not need to be changed.

        //public void SetRows(int r)
        //{
        //    rows = r;
        //}

        //public void SetColumns(int c)
        //{
        //    columns = c;
        //}

        // ========================================================================
        //                                  Methods
        // ========================================================================
        // Constructor
        //I modified the constructor to allow access to the textboxes in the form it is created in.
        public Board(TextBox[,] tbs)
        {
            //=========================
            //   2D array of Cells
            //=========================

            // Initialize the board with empty cells
            board = new Cell[rows, columns];

            // Fill the board with empty cells
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    // Create a new cell at the current position with no player occupying it
                    board[x, y] = new Cell(x, y, 0);
                }
            }

            textBoxes = tbs;
            //testing that it changes color
            //textBoxes[0,5].BackColor = Color.Red;
        }

        // Check if the board is full. Used to determine if the game is a draw
        public bool IsFull()
        {
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    // If any cell is empty, the board is not full
                    if (board[x, y].GetPlayer() == 0)
                    {
                        return false;
                    }
                }
            }

            // If no empty cells are found, the board is full
            return true;
        }

        // Check if a player has won the game
        public bool CheckWin(int player)
        {
            // Check for a horizontal win
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns - 3; y++)
                {
                    // Check if there are four cells in a row that are the same player
                    if (board[x, y].GetPlayer() == player &&
                        board[x, y + 1].GetPlayer() == player &&
                        board[x, y + 2].GetPlayer() == player &&
                        board[x, y + 3].GetPlayer() == player)
                    {
                        return true;
                    }
                }
            }

            // Check for a vertical win
            for (int y = 0; y < columns; y++)
            {
                for (int x = 0; x < rows; x++)
                {
                    // Check if there are four cells in a row that are the same player
                    if (x + 3 < rows &&
                        board[x, y].GetPlayer() == player &&
                        board[x + 1, y].GetPlayer() == player &&
                        board[x + 2, y].GetPlayer() == player &&
                        board[x + 3, y].GetPlayer() == player)
                    {
                        return true;
                    }
                }
            }

            // Check for an ascending diagonal win (/)
            for (int x = 3; x < rows; x++)
            {
                for (int y = 0; y < columns - 3; y++)
                {
                    // Check if there are four cells in a row that are the same player
                    if (board[x, y].GetPlayer() == player &&
                        board[x - 1, y + 1].GetPlayer() == player &&
                        board[x - 2, y + 2].GetPlayer() == player &&
                        board[x - 3, y + 3].GetPlayer() == player)
                    {
                        return true;
                    }
                }
            }

            // Check for a descending diagonal win (\)
            for (int x = 0; x < rows - 3; x++)
            {
                for (int y = 0; y < columns - 3; y++)
                {
                    // Check if there are four cells in a row that are the same player
                    if (board[x, y].GetPlayer() == player &&
                        board[x + 1, y + 1].GetPlayer() == player &&
                        board[x + 2, y + 2].GetPlayer() == player &&
                        board[x + 3, y + 3].GetPlayer() == player)
                    {
                        return true;
                    }
                }
            }

            // If all of the above checks fail, then no win was found
            return false;
        }

        public void ChangeColor(int r, int c)
        {
            if (board[r,c].GetPlayer() == 1)
            {
            textBoxes[r, c].BackColor = Color.Red;
            }
            else if (board[r, c].GetPlayer() == 2)
            {
            textBoxes[r, c].BackColor = Color.Yellow;
            }
            else
            {
            Console.WriteLine("ERROR IN COLOR CHANGE");
            }
        }

    }
}
