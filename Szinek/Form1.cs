using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szinek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.FromName(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.ForeColor = Color.FromName(textBox2.Text);
        }
    }
}
