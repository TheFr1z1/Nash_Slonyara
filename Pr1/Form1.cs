using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr1
{
    public partial class Form1 : Form
    {
        private int balance = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int n1 = random.Next(0, 10);
            int n2 = random.Next(0, 10);
            int n3 = random.Next(0, 10);
            label1.Text = n1.ToString();
            label2.Text = n2.ToString();
            label3.Text = n3.ToString();
            CheckWin(n1, n2, n3);
        }
       private void CheckWin(int n1, int n2, int n3)
        {
            if (n1 == n2 && n2 != n3)
            {
                if (n1 == 7)
                {
                    Check.Text = "Джекпот";
                    pictureBox1.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Pr1\\money.jpg");
                    balance += 50;
                }
                else
                {
                    Check.Text = "Вы выиграли";
                    balance += 20;
                }
            }
            else
            {
                Check.Text = "Попробуйте снова";
                balance -= 5;
            }
            Updatebalancelabel();
        }
        private void Updatebalancelabel()
        {
            balance5.Text = $"Баланс:{balance}";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
