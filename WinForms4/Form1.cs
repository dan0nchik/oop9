using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private int count = 0, countdown = 10;
        private double lucky = 0; 
        private void button1_Click(object sender, EventArgs e)
        {
            int rndNum = RandomNumber(1,10);
            

            if (int.TryParse(textBox1.Text, out int num))
            {
                if (rndNum == num)
                {
                    label2.Text = "Угадали!";
                    lucky++;
                }
                else
                {
                    label2.Text = "Не угадали!";
                }
            }
            else
            {
                label2.Text = "Не число!";
            }
            count++;
            countdown--;
            label3.Text = $"Осталось попыток: {countdown}";
            textBox1.Text = "";
            if (count == 10)
            {
                label1.Text = $"ВАШ КОЭФФИЦЕНТ НЕВЕЗУЧЕСТИ: {(10-lucky) / 10}";
                button1.Enabled = false;
                label2.Text = "";
            }
        }
    }
}
