using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            double add = Convert.ToDouble(this.textBox1.Text);
            total = total + add;
            label3.Text = ""+total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total = 0;
            label3.Text = "" + total;
        }
    }
}
