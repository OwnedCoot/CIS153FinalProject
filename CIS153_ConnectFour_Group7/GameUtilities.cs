using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CIS153_ConnectFour_Group7
{
    internal class GameUtilities
    {
        // ==================================================================
        //                      Statistics File Handling
        // ==================================================================

        /* The Statistics file is a text file that contains 3 lines of integers:
         * 1. Total number of Player 1 wins
         * 2. Total number of draws
         * 3. Total number of Player 2/CPU wins
         */

        // If the statistics file is empty, fill the first 3 lines with 0s
        public static void InitStatistics()
        {
            /* Since the default directory for reading text files is the bin/Debug folder, we need to move up two directories to the project folder.
             * This is done by:
             * 1. Getting the current directory (Environment.CurrentDirectory) [CIS153_ConnectFour_Group7/bin/Debug]
             * 2. Getting the parent directory of the current directory (Directory.GetParent(...)) [CIS153_ConnectFour_Group7/bin]
             * 3. Getting the parent directory of the parent directory of the current directory (.Parent) [CIS153_ConnectFour_Group7]
             * 4. Get the full path of the parent directory of the parent directory of the current directory (.FullName) [full path of CIS153_ConnectFour_Group7]
             * 5. Combine the full path to the project folder with the file name to get the full path to the file (Path.Combine(...))
             */

            // Path to the file should be something like "C:\Users\...\CIS153_ConnectFour_Group7\Statistics.txt"
            string fileName = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Statistics.txt");

            // If the file already has data, do not overwrite it
            if (File.ReadAllLines(fileName).Length > 0)
            {
                return;
            }

            // Create a new string list with 3 lines of 0s
            List<string> stats = new List<string> { "0", "0", "0" };

            // Write the 3 lines to the file
            File.WriteAllLines(fileName, stats);
        }


        // Read all lines from the statistics file and return them as a string list
        public static List<string> ReadStatistics()
        {
            // Get the full path to the file using the same method as InitStatistics()
            string fileName = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Statistics.txt");

            // Read all lines from the file into a string list
            List<string> stats = File.ReadAllLines(fileName).ToList();

            return stats;
        }

        // Write the statistics to the statistics file from a string list
        public static void WriteStatistics(List<string> stats)
        {
            // Get the full path to the file using the same method as InitStatistics()
            string fileName = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Statistics.txt");

            // Write all lines to the file
            File.WriteAllLines(fileName, stats);
        }

        // ==================================================================
        //                      Moves File Handling
        // ==================================================================

        /* The Moves file is a text file that contains a list of moves in the format:
         * [Player],[Row],[Column]
         * where: [Player] is either 1 or 2, [Column] is the column number (0-6), and [Row] is the row number (0-5)
         */

        // Read all lines from the moves file and return them as a string list
        public static List<string> ReadMoves()
        {
            // Get the full path to the file using the same method as InitStatistics(), but with Moves.txt as the file name
            string fileName = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Moves.txt");

            // Read all lines from the file into a string list
            List<string> moves = File.ReadAllLines(fileName).ToList();

            return moves;
        }

        // Write the moves to the moves file from a string list
        public static void WriteMoves(List<string> moves)
        {
            // Get the full path to the file using the same method as InitStatistics(), but with Moves.txt as the file name
            string fileName = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Moves.txt");

            // Write all lines to the file
            File.WriteAllLines(fileName, moves);
        }

        // ==================================================================
        //                          Other Utilities
        // ==================================================================
        
        // Change the current player from 1 to 2 or 2 to 1
        public static int ChangePlayer(int curPlr)
        {
            if (curPlr == 1)
            {
                return 2;
            }
            
            return 1;
        }

        // Drop a piece in a column and return the row it was dropped in
        public static void DropPiece(Board b, int col, int plr, List<string> moves)
        {
            // Check if the column is full
            if (!b.IsColumnFull(col))
            {
                // Drop the piece in the column
                for (int row = b.GetRows() - 1; row >= 0; row--)
                {
                    // Find the lowest empty cell in the column
                    if (b.GetCell(row, col).GetPlayer() == 0)
                    {
                        // Set the player in the cell and return the row
                        b.GetCell(row, col).SetPlayer(plr);

                        // Switch players
                        ChangePlayer(plr);

                        // Change the color of the cell
                        b.ChangeColor(row, col);

                        // Save the move to the moves string list in the format: [Player],[Row],[Column]
                        moves.Add($"{plr},{row},{col}");

                        // Exit the loop
                        break;
                    }
                }

                // Write the moves to the moves file
                WriteMoves(moves);
            }
        }
    }
}
