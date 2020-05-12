using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckMeter
{
    public partial class Form1 : Form
    {
        private int num;
        private int times;
        public Form1()
        {
            InitializeComponent();
            num = new Random().Next(1, 11);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input;
            bool success = int.TryParse(this.textBox1.Text, out input);
            if (success)
            {
                if (input == num || times == 10)
                {
                    this.label3.Text = "Коэффицент везения: " + ((double)num / 10).ToString();
                    this.label2.Text = "Вы угдали";
                }
                else
                {
                    
                    this.label2.Text = "Не угадали";
                    this.label2.Left += 50;
                    times++;
                }
            }
        }
    }
}