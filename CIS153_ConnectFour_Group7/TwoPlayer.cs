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


        //Testing for making transparent
        //private void column1_Click(object sender, EventArgs e)
        //{
        //    Bitmap bitmap0 = new Bitmap(pictureBox1.Image);
        //    var bt = MakeTransparent(bitmap0, Color.White, 30);
        //    pictureBox1.Image = bt;
        //}
        //private Bitmap MakeTransparent(Bitmap bitmap, Color color, int tolerance)
        //{
        //    Bitmap transparentImage = new Bitmap(bitmap);

        //    for (int i = transparentImage.Size.Width - 1; i >= 0; i--)
        //    {
        //        for (int j = transparentImage.Size.Height - 1; j >= 0; j--)
        //        {
        //            var currentColor = transparentImage.GetPixel(i, j);
        //            if (Math.Abs(color.R - currentColor.R) < tolerance &&
        //              Math.Abs(color.G - currentColor.G) < tolerance &&
        //              Math.Abs(color.B - currentColor.B) < tolerance)
        //                transparentImage.SetPixel(i, j, color);
        //        }
        //    }

        //    transparentImage.MakeTransparent(color);
        //    return transparentImage;
        //}

        //this was the the leftover basic code for pen to draw objects, left it here in case we wanted to revist the idea feel free to delet if you wish
        //private void TwoPlayer_Paint(object sender, PaintEventArgs e)
        //{
        //    Color Blue = Color.FromArgb(0,0,255);
        //    Pen BluePen = new Pen(Blue);
        //}
    }
}
