using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_ConnectFour_Group7
{
    internal class Cell
    {
        private int row;
        private int column;

        // 0 = empty, 1 = player 1, 2 = player 2 or computer
        private int player;

        // ========================================================================
        //                                  Getters
        // ========================================================================
        public int GetRow()
        {
            return row;
        }

        public int GetColumn()
        {
            return column;
        }

        public int GetPlayer()
        {
            return player;
        }

        // ========================================================================
        //                                  Setters
        // ========================================================================
        public void SetRow(int r)
        {
            row = r;
        }

        public void SetColumn(int c)
        {
            column = c;
        }

        public void SetPlayer(int p)
        {
            player = p;
        }

        // ========================================================================
        //                                  Methods
        // ========================================================================
        // Constructor
        public Cell(int r, int c, int p)
        {
            row = r;
            column = c;
            player = p;
        }

        public void ChangeColor(int r, int c, int p)
        {

        }
    }
}
