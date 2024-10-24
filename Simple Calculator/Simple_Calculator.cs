using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Simple_Calculator : Form
    {
        double result;
        string operation = "";
        bool isOperation = false;
        public Simple_Calculator()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtResult.Text=(result + Double.Parse(txtResult.Text)).ToString();
                    break;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
           // txtResult.Text = txtResult.Text + "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "1";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "1";
            isOperation = false;
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "/";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "2";
            isOperation = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "3";
            isOperation = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "4";
            isOperation = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "5";
            isOperation = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "6";
            if ((txtResult.Text == "0")||(isOperation))
            {
                txtResult.Clear();

            }
            isOperation = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text=="0")
            {
                txtResult.Clear();

            }
            txtResult.Text = txtResult.Text + "7";
            isOperation = false;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "8";
            isOperation = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "9";
            isOperation = false;
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + ".";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "+";
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "-";
        }

        private void btnmlp_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "*";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operation = button.Text;
            result = Double.Parse(txtResult.Text);
            isOperation = true;
        }
    }
}
