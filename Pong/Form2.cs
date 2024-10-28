using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pong
{
    public partial class Form2 : Form
    {
        private int Pallete;
        private int Ball;

        public Form2(int pallete, int ball)
        {
            Ball = ball;
            Pallete = pallete;

            InitializeComponent();
        }
        private void OnAppLoad(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }

            var wyniki = new List<string>();

            var plik = File.OpenText("wyniki.txt");
            for (var line = plik.ReadLine(); line is not null; line = plik.ReadLine())
            {
                var values = line.Split(':').Select(long.Parse).ToList();
                var datetime = DateTime.FromBinary(values[2]);

                //MessageBox.Show($"Gracz: {values[0]}, AI: {values[1]}, Data: {datetime}");

                string temp = $"Gracz {values[0]}:{values[1]} AI,   W dacie: {datetime}";

                wyniki.Add(temp);



            }
            plik.Close();
            label2.Text = wyniki[1];
            label3.Text = wyniki[2];

            label4.Text = wyniki[3];
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
