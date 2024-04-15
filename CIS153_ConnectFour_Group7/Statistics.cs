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
    public partial class Statistics : Form
    {
        form_TitleScreen pform;

        //==========CONSTRUCTORS==========
        public Statistics()
        {
            InitializeComponent();
        }

        //overloaded constructor
        public Statistics(form_TitleScreen pf)
        {
            InitializeComponent();
            //this passes the parent form to this form so we can get back to it.
            pform = pf;
        }

        //==========BUTTON CLICKS==========
        private void btn_quit2_Click(object sender, EventArgs e)
        {
            //Exits the application on click
            System.Environment.Exit(0);
        }
    }
}
