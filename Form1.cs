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
        //using a running total to add up the numbers
        double total = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //adds the number in the textbox to the total and displays the new total
            double add = Convert.ToDouble(this.textBox1.Text);
            total = total + add;
            label3.Text = ""+total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //resets the total
            total = 0;
            label3.Text = "" + total;
        }
    }
}
