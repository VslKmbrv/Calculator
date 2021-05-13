using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool operation_pressed = false;
        double memory;
        bool memory_flag;

        public Form1()
        {
            InitializeComponent();

            MClearButton.Enabled = false;
            MRecallButton.Enabled = false;

        }

        // Numbers and decimal coma buttons
        private void numbers_Only(object sender, EventArgs e)
        {
            if((txtDisplay.Text == "0") || (operation_pressed) || (memory_flag))
            {
                txtDisplay.Clear();
                memory_flag = false;
            }

            operation_pressed = false;
            Button b = (Button)sender;
            if(b.Text == ",")
            {
                if(!txtDisplay.Text.Contains(","))
                    txtDisplay.Text = txtDisplay.Text + b.Text;

            }else
            txtDisplay.Text = txtDisplay.Text + b.Text;
        }

        // + - * ÷ buttons
        private void operators_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (result != 0)
            {
                EqualButton.PerformClick();
                operation = b.Text;
                lblShowOperations.Text = result + "    " + operation;
                operation_pressed = true;
                
            }
            else
            {
                operation = b.Text;
                result = Double.Parse(txtDisplay.Text);
                lblShowOperations.Text = result + "    " + operation;
                operation_pressed = true;
            }

        }

        // Equals button
        private void bntEquals_Click(object sender, EventArgs e)
        {
            lblShowOperations.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "×":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "÷":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(txtDisplay.Text);
            lblShowOperations.Text = "";
        }

        // CE button
        private void ClearEntryButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        // C button
        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
        }
         
        // Delete button
        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            if (txtDisplay.Text.Length == 0)
                txtDisplay.Text = "0";
        }

        // Square root
        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            Double root = Math.Sqrt(Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = Convert.ToString(root);
        }

        // Memory read
        private void MR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memory.ToString();
            memory_flag = true;

        }

        // Memory save
        private void MS_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(txtDisplay.Text);

            MRecallButton.Enabled = true;
            MClearButton.Enabled = true;
            memory_flag = true;

        }

        // Memory clear
        private void MC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            memory = 0;
            MRecallButton.Enabled = false;
            MClearButton.Enabled = false;
        }

        // Memory plus
        private void MPlus_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(txtDisplay.Text);

        }

        // Memory minus
        private void MMinus_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(txtDisplay.Text);
        }

    }
}
