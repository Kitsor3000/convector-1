using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Convector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;

           
            if (!double.TryParse(textBox1.Text, out a) || a <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну суму.", "Неправильне введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            double b = a / 42.6;
            double c = a / 46.5;
            double f = a / 10.74;

           
            textBox4.Text = c.ToString("0.00");
            textBox2.Text = b.ToString("0.00");
            textBox3.Text = f.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        

        private void вихідToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
