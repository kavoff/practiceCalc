using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static practiceCalc.TwoArgumentsCalculator;
using static practiceCalc.ITwoArguments;

namespace practiceCalc
{
    
    public partial class Form1 : Form
    {
        public string operation;
        public string x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mathematicFunction mathFunc = new mathematicFunction();
            Button A = (Button)sender;
            operation = A.Text;
            x = textBox1.Text;
            y = textBox2.Text;
            double nx = Convert.ToDouble(x);
            double ny = Convert.ToDouble(y);
            double result = 0;
            // ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(имяКалькулятора);

            /*
            switch(A.Text)
            {
                case "+":
                    result = mathFunc.Addition(nx, ny);
                    break;
                case "-":
                    mathFunc.substract(nx, ny);
                    break;
            }
            */

            /*if(operation == "+")
            {
                result = nx + ny;
            }
            if (operation == "-")
            {
                result = nx - ny;
            }
            if (operation == "×")
            {
                result = nx * ny;
            }
            if (operation == "/")
            {
                result = nx / ny;
            }
            if (operation == "x^y")
            {
                result = Math.Pow(nx, ny);
            }
            if (operation == "x%y")
            {
                result = nx % ny;
            }
            */
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
