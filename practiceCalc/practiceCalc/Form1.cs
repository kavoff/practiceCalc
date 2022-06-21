﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Button A = (Button)sender;
            operation = A.Text;
            x = textBox1.Text;
            y = textBox2.Text;
            double nx = Convert.ToDouble(x);
            double ny = Convert.ToDouble(y);
            double result = 0;
            if(operation == "+")
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
                result = Math.Pow(nx,ny);
            }
            if (operation == "x%y")
            {
                result = nx % ny;
            }
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
