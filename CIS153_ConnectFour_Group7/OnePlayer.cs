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
        }

        //==========BUTTON CLICKS==========
        private void btn_quit3_Click(object sender, EventArgs e)
        {
            //Exits the application on click
            System.Environment.Exit(0);
        }
    }
}
