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
        myCalc calc = new myCalc();
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
            } else if ((output.Text == "0") || (calc.operation))
            {
                output.Clear();
                output.Text = output.Text + button.Text;
            }
            
            else
                output.Text = output.Text + button.Text;
            calc.operation = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            calc.value = 0;
            output.Text = "0";
            lblOutput.Text = "";
        }

        private void opr_press(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (calc.value != 0)
            {
                calc.value2 = output.Text;
                calc.Operation();
                output.Text = calc.value2;
                calc.text = button.Text;
            }

            calc.text = button.Text;
            calc.value = float.Parse(output.Text);
            output.Text = "";
            lblOutput.Text = calc.value + " " + calc.text;
            calc.operation = true;
            
        }
        

        private void op_result(object sender, EventArgs e)
        {
            calc.value2 = output.Text;
            calc.newlblOutput = lblOutput.Text;
            calc.Operation();
            output.Text = calc.value2;
            lblOutput.Text = calc.newlblOutput;
            calc.value = 0;
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
            calc.memory = float.Parse(output.Text);
            output.Text = "0";
        }

        private void BtnMR_Click(object sender, EventArgs e)
        {
            output.Text = calc.memory.ToString();
        }

        private void BtnMadd_Click(object sender, EventArgs e)
        {
            calc.memory = calc.memory + float.Parse(output.Text);
            output.Text = "0";
        }

        private void BtnMsubtract_Click(object sender, EventArgs e)
        {
            calc.memory = calc.memory - float.Parse(output.Text);
            output.Text = "0";
        }

        private void BtnMC_Click(object sender, EventArgs e)
        {
            calc.memory = 0;
            output.Text = "0";
        }
    }
}
