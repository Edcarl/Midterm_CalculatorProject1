using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_CalculatorProject
{
    public partial class Calculator : Form
    {

        float value = 0;
        string text = "";
        bool operation = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if((output.Text == "0")||(operation))
            {
                output.Clear();
            }

            Button button = (Button)sender;
            output.Text = output.Text + button.Text;
            operation = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void opr_press(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            value = float.Parse(output.Text);
            operation = true;
        }

        private void op_result(object sender, EventArgs e)
        {
            if(text == "+")
            {
                output.Text = (value + Double.Parse(output.Text)).ToString();
            } else if(text == "-")
            {
                output.Text = (value - Double.Parse(output.Text)).ToString();
            } else if(text == "*")
            {
                output.Text = (value * Double.Parse(output.Text)).ToString();
            } else if(text == "/")
            {
                output.Text = (value / Double.Parse(output.Text)).ToString();
            }

            operation = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            if (output.Text.Length > 0)
            {
                output.Text = output.Text.Remove(output.Text.Length - 1, 1);
            }
        }
    }
}
