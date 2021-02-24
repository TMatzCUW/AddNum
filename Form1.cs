﻿using System;
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
        //a previous total holder for an undo
        double previoustotal = 0;
        //how many times something has been added
        int shims = 0;
        //another previous for shims
        int previousshims = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //adds the number in the textbox to the total and displays the new total
            //same for shims
            try
            {
                double add = Convert.ToDouble(this.textBox1.Text);
                previoustotal = total;
                previousshims = shims;
                total = total + add;
                label3.Text = "" + total;
                shims += 1;
                label5.Text = "" + shims;
            }
            catch (Exception ex) //To prevent errors that would give users a heart attack
            {
                MessageBox.Show("Please put in a number, not whatever you just attempted","Warning");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //resets the totals and clears input box
            total = 0;
            label3.Text = "" + total;
            textBox1.Text = "";
            shims = 0;
            label5.Text = "" + shims;
            previousshims = 0;
            previoustotal = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //goes back one interation
            total = previoustotal;
            shims = previousshims;
            label3.Text = "" + total;
            label5.Text = "" + shims;
        }
    }
}
