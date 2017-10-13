using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kazino777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random Rnd = new Random();

        private int balance = 0;
        private void Play_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            label1.Text = Rnd.Next(0, 10).ToString();
            label2.Text = Rnd.Next(0, 10).ToString();
            label3.Text = Rnd.Next(0, 10).ToString();

            int count = 0;

            if (label1.Text == "7") count++;
            if (label2.Text == "7") count++;
            if (label3.Text == "7") count++;

            if (count != 0)
            {
                balance += (int)Math.Pow(10, count);
                lblMessage.Text = "Выигрышь: " + Math.Pow(10, count).ToString();
            }
            Text = "Баланс: " + balance.ToString();

        }

        private void buy_Click(object sender, EventArgs e)
        {
            BuyForm f = new BuyForm();

            if (f.ShowDialog() == DialogResult.OK)
            {
                balance += f.Amount;
                Text = "Баланс: " + balance.ToString();
            }
        }
    }
}
