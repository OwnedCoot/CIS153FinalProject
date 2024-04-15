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
    public partial class form_TitleScreen : Form
    {
        //==========CONSTRUCTOR==========

        public form_TitleScreen()
        {
            InitializeComponent();
        }

        //==========BUTTON CLICKS==========

        private void btn_title_Quit_Click(object sender, EventArgs e)
        {
            //Exits the application on click
            System.Environment.Exit(0);
        }

        private void btn_title_OnePlayer_Click(object sender, EventArgs e)
        {
            loadNewOnePlayerForm();
        }

        private void btn_title_TwoPlayer_Click(object sender, EventArgs e)
        {
            loadNewTwoPlayerForm();
        }

        private void btn_title_Statistics_Click(object sender, EventArgs e)
        {
            loadNewStatsForm();
        }

        //==========FUNCTIONS==========

        public void loadNewOnePlayerForm()
        {
            //using overloaded constructor to load the original StartForm
            OnePlayer formToLoad = new OnePlayer(this);

            formToLoad.Show();
            //form_TitleScreen is the parent form. form_TitleScreen is the same as Form1 but you must use
            //form_TitleScreen when refferencing this form to other forms.

            this.Hide();
        }

        public void loadNewTwoPlayerForm()
        {
            //using overloaded constructor to load the original StartForm
            TwoPlayer formToLoad = new TwoPlayer(this);

            formToLoad.Show();
            //form_TitleScreen is the parent form. form_TitleScreen is the same as Form1 but you must use
            //form_TitleScreen when refferencing this form to other forms.

            this.Hide();
        }

        public void loadNewStatsForm()
        {
            //using overloaded constructor to load the original StartForm
            Statistics formToLoad = new Statistics(this);

            formToLoad.Show();
            //form_TitleScreen is the parent form. form_TitleScreen is the same as Form1 but you must use
            //form_TitleScreen when refferencing this form to other forms.

            this.Hide();
        }
    }
}
