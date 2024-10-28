using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form3 : Form
    {
        private int pallette;
        private int ball;

        public Form3()
        {
            InitializeComponent();
        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pallette = Convert.ToInt32(numericUpDown1.Value);
        }

        private void OnAppLoad(object sender, EventArgs e)
        {
            Form2 form2Form = new Form2(pallette, ball);
            if (form2Form.ShowDialog(this) == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            Form2 form2Form = new Form2(pallette, ball);
            if (form2Form.ShowDialog(this) == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        public void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ball = Convert.ToInt32(numericUpDown2.Value);
        }
    }
}
