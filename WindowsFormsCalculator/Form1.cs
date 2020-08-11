using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorAssignment;

namespace WindowsFormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClassCalculator calc= new ClassCalculator();
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            calc.Num1 = Convert.ToInt32(txtNum1.Text);
            calc.Num2 = Convert.ToInt32(txtNum2.Text);
            lblAdd.Text= "Addition :" +calc.Add().ToString();
           
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

           
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSub_Click_1(object sender, EventArgs e)
        {
            calc.Num1 = Convert.ToInt32(txtNum1.Text);
            calc.Num2 = Convert.ToInt32(txtNum2.Text);
            lblAdd.Text = "Substraction :" + calc.Substract().ToString();
        }

        private void btnMul_Click_1(object sender, EventArgs e)
        {
            calc.Num1 = Convert.ToInt32(txtNum1.Text);
            calc.Num2 = Convert.ToInt32(txtNum2.Text);

            lblAdd.Text = "Multiplication :" + calc.Multiply().ToString();
        }

        private void btnDiv_Click_1(object sender, EventArgs e)
        {
            calc.Num1 = Convert.ToInt32(txtNum1.Text);
            calc.Num2 = Convert.ToInt32(txtNum2.Text);

            lblAdd.Text = "Divison" + calc.Divide().ToString();
        }
    }
}
