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
        private Size defaultASize;
        private Point defaultBLocation;
        private static Random rand = new Random();
        private int max = byte.MaxValue + 1;//256
        private int r, g, b;//color
        private void Form1_Load(object sender, EventArgs e)
        {
            defaultASize = A.Size;
            defaultBLocation = B.Location;
        }
        private void A_Click(object sender, EventArgs e)
        {
            r = rand.Next(max);
            g = rand.Next(max);
            b = rand.Next(max);
            B.BackColor = Color.FromArgb(r, g, b);
            int xB = B.Location.X, yB = B.Location.Y;
            B.Location = new Point(xB+4, yB+2);
            if(B.Right >= ActiveForm.Size.Width-15 || B.Bottom >= ActiveForm.Size.Height-40)
            {
                B.Location = defaultBLocation;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            int aW = A.Size.Width, aH = A.Size.Height;
            r = rand.Next(max);
            g = rand.Next(max);
            b = rand.Next(max);
            A.BackColor = Color.FromArgb(r, g, b);
            A.Size = new Size(aW-2, aH);
            if (A.Size.Width == A.MinimumSize.Width)
            {
                A.Size = defaultASize;
            }
        }
    }
}
