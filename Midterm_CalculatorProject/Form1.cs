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
            //output.Text = output.Text + button.Text;
            if (button.Text == ".")
            {
                if (!output.Text.Contains("."))
                    output.Text = output.Text + button.Text;
            }
            else
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
            Operation();
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

        private void btnSign_Click(object sender, EventArgs e)
        {
            output.Text = (float.Parse(output.Text) * -1).ToString();
        }

        private void Operation()
        {
                if (text == "+")
                {
                    output.Text = (value + float.Parse(output.Text)).ToString();
                }
                else if (text == "-")
                {
                output.Text = (value - float.Parse(output.Text)).ToString();
                }
                else if (text == "*")
                {
                output.Text = (value * float.Parse(output.Text)).ToString();
                }
                else if (text == "/")
                {
                output.Text = (value / float.Parse(output.Text)).ToString();
                }
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            output.Text = Math.Sqrt(float.Parse(output.Text)).ToString();
        }

        private void btnSquared_Click(object sender, EventArgs e)
        {
            output.Text = Math.Pow(float.Parse(output.Text), 2).ToString();
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            output.Text = (1 / (float.Parse(output.Text))).ToString();
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            output.Text = (float.Parse(output.Text) * 0.01).ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }
    }
}
