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

            // Create a new string array with 3 lines of 0s
            string[] stats = new string[3] { "0", "0", "0" };

            // Write the 3 lines to the file
            File.WriteAllLines(fileName, stats);
        }


        // Read all lines from the statistics file and return them as a string array
        public static string[] ReadStatistics()
        {
            // Get the full path to the file using the same method as InitStatistics()
            string fileName = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Statistics.txt");

            // Read all lines from the file into a string array
            string[] stats = File.ReadAllLines(fileName);

            return stats;
        }

        // Write the statistics to the statistics file from a string array
        public static void WriteStatistics(string[] stats)
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
         * [Player],[Column],[Row]
         * where: [Player] is either 1 or 2, [Column] is the column number (0-6), and [Row] is the row number (0-5)
         */

        // Read all lines from the moves file and return them as a string array
        public static string[] ReadMoves()
        {
            // Get the full path to the file using the same method as InitStatistics(), but with Moves.txt as the file name
            string fileName = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Moves.txt");

            // Read all lines from the file into a string array
            string[] moves = File.ReadAllLines(fileName);

            return moves;
        }

        // Write the moves to the moves file from a string array
        public static void WriteMoves(string[] moves)
        {
            // Get the full path to the file using the same method as InitStatistics(), but with Moves.txt as the file name
            string fileName = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Moves.txt");

            // Write all lines to the file
            File.WriteAllLines(fileName, moves);
        }

    }
}
