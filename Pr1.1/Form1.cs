using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pr1
{
    public partial class Form1 : Form
    {
        private int balance = 100;
        private int betAmount = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(betTextBox.Text, out betAmount) || betAmount <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректную сумму ставки.");
                return;
            }

            if (betAmount > balance)
            {
                MessageBox.Show("Недостаточно средств для ставки.");
                return;
            }

           
            balance -= betAmount;

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
            if (n1 == n2 && n2 != n3 || (n1 != n2 && n2 == n3))
            {
                if (n1 == 7 && n2 == 7 && n3 == 7)
                {
                    Check.Text = "Джекпот";
                    pictureBox1.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Pr1\\money.jpg");
                    balance += betAmount * 100; 
                }
                else
                {
                    Check.Text = "Вы выиграли";
                    balance += betAmount * 5; 
                }
            }
            else
            {
                Check.Text = "Попробуйте снова";
         
            }

            if (balance <= 0)
            {
                MessageBox.Show("Вы все Проиграли! С любовью админы бурмалды!<3");
                Application.Exit(); 
            }

            Updatebalancelabel();
        }

        private void Updatebalancelabel()
        {
            balance5.Text = $"Баланс: {balance}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

