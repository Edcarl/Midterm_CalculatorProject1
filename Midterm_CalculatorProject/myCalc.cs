using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CalculatorProject
{
    class myCalc
    {
        public float value = 0;
        public string text = "";
        public float memory = 0;
        public bool operation = false;
        public string value2 = "";
        public string newlblOutput = "";


        public void Operation()
        {
            switch (text)
            {
                case "+":
                    value2 = (value + float.Parse(value2)).ToString();
                    break;
                case "-":
                    value2 = (value - float.Parse(value2)).ToString();
                    break;
                case "*":
                    value2 = (value * float.Parse(value2)).ToString();
                    break;
                case "/":
                    value2 = (value / float.Parse(value2)).ToString();
                    break;
                default:
                    break;
            }

            value = float.Parse(value2);
            newlblOutput = " ";
        }

    }
}
