using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_ConnectFour_Group7
{
    internal class Board
    {
        private int rows;
        private int columns;

        // Creates a 2D array of Cells in the format [row, column]
        private Cell[,] board;

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
        public void SetRows(int r)
        {
            rows = r;
        }

        public void SetColumns(int c)
        {
            columns = c;
        }

        // ========================================================================
        //                                  Methods
        // ========================================================================
        // Constructor
        public Board(int r, int c)
        {
            rows = r;
            columns = c;

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
            // TODO: Implement win checkin
        }
    }
}
