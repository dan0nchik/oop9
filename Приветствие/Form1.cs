using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приветствие
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void Hello_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                textBox2.Text = $"Привет, {textBox1.Text}!";
            }
            else
            {
                textBox2.Text = "Здравствуй, мир!";
            }
        }
    }
}
