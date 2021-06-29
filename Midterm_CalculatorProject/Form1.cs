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
        float memory = 0;
        bool operation = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (button.Text == ".")
            {
                if (!output.Text.Contains("."))
                    output.Text = output.Text + button.Text;
                if (output.Text == "0")
                    output.Text = output.Text + button.Text;
            } else if ((output.Text == "0") || (operation))
            {
                output.Clear();
                output.Text = output.Text + button.Text;
            }
            
            else
                output.Text = output.Text + button.Text;
            operation = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            value = 0;
            output.Text = "0";
            lblOutput.Text = "";
        }

        private void opr_press(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (value != 0)
            {
                Operation();
                text = button.Text;
            }

            text = button.Text;
            value = float.Parse(output.Text);
            output.Text = "";
            lblOutput.Text = value + " " + text;
            operation = true;
            
        }

        private void op_result(object sender, EventArgs e)
        {
            Operation();
            value = 0;
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
            switch (text)
            {
                case "+":
                    output.Text = (value + float.Parse(output.Text)).ToString();
                    break;
                case "-":
                    output.Text = (value - float.Parse(output.Text)).ToString();
                    break;
                case "*":
                    output.Text = (value * float.Parse(output.Text)).ToString();
                    break;
                case "/":
                    output.Text = (value / float.Parse(output.Text)).ToString();
                    break;
                default:
                    break;
            }
                
            value = float.Parse(output.Text);
            lblOutput.Text = " ";
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

        private void BtnMS_Click(object sender, EventArgs e)
        {
            memory = float.Parse(output.Text);
            output.Text = "0";
        }

        private void BtnMR_Click(object sender, EventArgs e)
        {
            output.Text = memory.ToString();
        }

        private void BtnMadd_Click(object sender, EventArgs e)
        {
            memory = memory + float.Parse(output.Text);
        }

        private void BtnMsubtract_Click(object sender, EventArgs e)
        {
            memory = memory - float.Parse(output.Text);
        }

        private void BtnMC_Click(object sender, EventArgs e)
        {
            memory = 0;
            output.Text = "0";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
