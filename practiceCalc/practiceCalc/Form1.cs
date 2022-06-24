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
using static practiceCalc.ITwoArgumentsCalculator;

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
            // Обработчик нажатия на кнопку, конвертирование кнопки в текст.
            Button A = (Button)sender;
            operation = A.Text;
            x = textBox1.Text;
            y = textBox2.Text;
            // Конвертирование текста в числовые значения
            firstArgument = Convert.ToDouble(x);
            secondArgument = Convert.ToDouble(y);
            double result;

            // Исключение деления на ноль. Вывод ошибки.
            try
            {
                CreateCalculator(operation);
            }
            catch (DivideByZeroException er)
            {
                textBox3.Text = er.Message;
            }

            // Вызов фабрики и запись результата вычислений в переменную
            result = CreateCalculator(operation);
            
            // Вывод результата в виде строки
            textBox3.Text = result.ToString();
        }
    }
}
