using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double miles;
            if (double.TryParse(textBox1.Text, out miles))
            {
                label2.Text = $"Указанное число миль равно: {miles / 0.621371} км";
            }
            else
            {
                label2.Text = "Это не число!";
            }
            
        }


    }
}
