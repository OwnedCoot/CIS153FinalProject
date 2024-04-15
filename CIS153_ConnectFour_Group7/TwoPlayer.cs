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

        //this was the the leftover basic code for pen to draw objects, left it here in case we wanted to revist the idea feel free to delet if you wish
        //private void TwoPlayer_Paint(object sender, PaintEventArgs e)
        //{
        //    Color Blue = Color.FromArgb(0,0,255);
        //    Pen BluePen = new Pen(Blue);
        //}
    }
}
