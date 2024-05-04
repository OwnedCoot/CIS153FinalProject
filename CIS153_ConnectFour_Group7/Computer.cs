using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_ConnectFour_Group7
{
    // The CPU for One Player mode
    internal class Computer
    {
        // Use the Random class to generate a random number
        private Random rand = new Random();

        // Return a random column to drop a piece in
        public int GetRandomColumn(Board b)
        {
            // Generate a random number between 0 and 6 as Next is exclusive of the upper bound
            int col = rand.Next(0, 7);

            // Check if the column is full
            while (b.IsColumnFull(col))
            {
                // If the column is full, generate a new random number
                col = rand.Next(0, 7);
            }

            // If the column is not full, return the column
            return col;
        }

        // Check for any winning moves given the current board state and player
        public int CheckWinningMove(Board b, int plr)
        {
            for (int r = 0; r < b.GetRows(); r++)
            {
                for (int c = 0; c < b.GetColumns(); c++)
                {
                    // Check horizontally
                    if (c < b.GetColumns() - 3)
                    {
                        // i represents the column where the player value would equal 0
                        // Ex. if i = 0, then the player value would be 0 at column c (0 1 1 1)
                        // Ex. if i = 1, then the player value would be 0 at column c + 1 (1 0 1 1) and so on...
                        for (int i = 0; i < 4; i++)
                        {
                            // Search col and the next 3 columns for a winning move by checking if at least 3 cells in a row
                            // are the same player, using i as the non-player column
                            // % 4 is used to wrap around the columns (at last col -> first col)
                            if (b.GetCell(r, c + i).GetPlayer() == 0 &&
                                b.GetCell(r, c + (i + 1) % 4).GetPlayer() == plr &&
                                b.GetCell(r, c + (i + 2) % 4).GetPlayer() == plr &&
                                b.GetCell(r, c + (i + 3) % 4).GetPlayer() == plr)
                            {
                                // Return the column where the player value would equal 0
                                return c + i;
                            }
                        }
                    }

                    // Check vertically
                    if (r < b.GetRows() - 3)
                    {
                        // i represents the column where the player value would equal 0
                        for (int i = 0; i < 4; i++)
                        {
                            // Search col and the next 3 columns for a winning move by checking if at least 3 cells in a row
                            // are the same player, using i as the non-player column
                            if (b.GetCell(r + i, c).GetPlayer() == 0 &&
                                b.GetCell(r + (i + 1) % 4, c).GetPlayer() == plr &&
                                b.GetCell(r + (i + 2) % 4, c).GetPlayer() == plr &&
                                b.GetCell(r + (i + 3) % 4, c).GetPlayer() == plr)
                            {
                                // Return the column where the player value would equal 0
                                return c;
                            }
                        }
                    }

                    // Check diagonally (down-right)
                    if (r < b.GetRows() - 3 && c < b.GetColumns() - 3)
                    {
                        // i represents the column where the player value would equal 0
                        for (int i = 0; i < 4; i++)
                        {
                            // Search col and the next 3 columns for a winning move by checking if at least 3 cells in a row
                            // are the same player, using i as the non-player column
                            if (b.GetCell(r + i, c + i).GetPlayer() == 0 &&
                                b.GetCell(r + (i + 1) % 4, c + (i + 1) % 4).GetPlayer() == plr &&
                                b.GetCell(r + (i + 2) % 4, c + (i + 2) % 4).GetPlayer() == plr &&
                                b.GetCell(r + (i + 3) % 4, c + (i + 3) % 4).GetPlayer() == plr)
                            {
                                // Return the column where the player value would equal 0
                                return c + i;
                            }
                        }
                    }

                    // Check diagonally (down-left)
                    if (r < b.GetRows() - 3 && c >= 3)
                    {
                        // i represents the column where the player value would equal 0
                        for (int i = 0; i < 4; i++)
                        {
                            // Search col and the next 3 columns for a winning move by checking if at least 3 cells in a row
                            // are the same player, using i as the non-player column
                            if (b.GetCell(r + i, c - i).GetPlayer() == 0 &&
                                b.GetCell(r + (i + 1) % 4, c - (i + 1) % 4).GetPlayer() == plr &&
                                b.GetCell(r + (i + 2) % 4, c - (i + 2) % 4).GetPlayer() == plr &&
                                b.GetCell(r + (i + 3) % 4, c - (i + 3) % 4).GetPlayer() == plr)
                            {
                                // Return the column where the player value would equal 0
                                return c - i;
                            }
                        }
                    }
                }
            }

            // If no winning moves are found, return -1
            return -1;
        }



        // Run through winning checks and place piece in the best column
        public void MakeMove(Board b, List<string> moves)
        {
            // Check for any winning moves for the player
            int pWinMove = CheckWinningMove(b, 1);

            // Check for any winning moves for the computer
            int CwinMove = CheckWinningMove(b, 2);
            
            // If a winning move is found for the computer, place a piece in the winning column
            // Checking for a winning move for the computer first ensures that the computer will win if it can
            if (CwinMove != -1)
            {
                // Drop a piece in the winning column
                GameUtilities.DropPiece(b, CwinMove, 2, moves);
            }
            
            // If a winning move is found for the player, place a piece in the winning column
            else if (pWinMove != -1)
            {
                // Drop a piece in the winning column
                GameUtilities.DropPiece(b, pWinMove, 2, moves);
            }

            // If no winning moves are found, place a piece in a random column
            else if (pWinMove == -1 && CwinMove == -1)
            {
                // Get a random column to drop a piece in
                int col = GetRandomColumn(b);
                
                // Drop a piece in the random column
                GameUtilities.DropPiece(b, col, 2, moves);
            }
        }
    }
}
