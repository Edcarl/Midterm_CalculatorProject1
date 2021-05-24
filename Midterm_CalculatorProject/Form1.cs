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

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (output.Text == "0")
            {
                output.Text = "";
            }
            output.Text = output.Text + button.Text;
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
            output.Clear();
            
        }

        private void op_result(object sender, EventArgs e)
        {
            if(text == "+")
            {
                output.Text = (value + float.Parse(output.Text)).ToString();
            } 
            else if(text == "-")
            {
                output.Text = (value - float.Parse(output.Text)).ToString();
            } 
            else if(text == "*")
            {
                output.Text = (value * float.Parse(output.Text)).ToString();
            } 
            else if(text == "/")
            {
                output.Text = (value / float.Parse(output.Text)).ToString();
            }

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
