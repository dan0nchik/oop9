using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace фоновая6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Size defaultASize;
        public Point defaultBLocation;
        private void Form1_Load(object sender, EventArgs e)
        {
            defaultASize = A.Size;
            defaultBLocation = B.Location;
        }
        private void A_Click(object sender, EventArgs e)
        {
            int xB = B.Location.X, yB = B.Location.Y;
            Console.WriteLine(ActiveForm.Size.Width);
            Console.WriteLine(B.Right);
            B.Location = new Point(xB+4, yB+2);
            if(B.Right >= ActiveForm.Size.Width-10 || B.Bottom >= ActiveForm.Size.Height-10)
            {
                B.Location = defaultBLocation;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            int aW = A.Size.Width, aH = A.Size.Height;

            A.Size = new Size(aW-2, aH);
            if (A.Size.Width == A.MinimumSize.Width)
            {
                A.Size = defaultASize;
            }
        }
    }
}
