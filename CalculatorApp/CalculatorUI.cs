using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private float number, answer;
        private int count;

        private void Disable()
        {
            outputTextBox.Enabled = false;
            onButton.Show();
            offButton.Hide();
            pointButton.Enabled = false;
            zeroButton.Enabled = false;
            oneButton.Enabled = false;
            twoButton.Enabled = false;
            threeButton.Enabled = false;
            fourButton.Enabled = false;
            fiveButton.Enabled = false;
            sixButton.Enabled = false;
            sevenButton.Enabled = false;
            eightButton.Enabled = false;
            nineButton.Enabled = false;
            backButton.Enabled = false;
            clearButton.Enabled = false;
            addtionButton.Enabled = false;
            subtractButton.Enabled = false;
            multiplicationButton.Enabled = false;
            divisionButton.Enabled = false;
            resultButton.Enabled = false;
        }

        private void Enable()
        {
            outputTextBox.Enabled = true;
            onButton.Hide();
            offButton.Show();
            pointButton.Enabled = true;
            zeroButton.Enabled = true;
            oneButton.Enabled = true;
            twoButton.Enabled = true;
            threeButton.Enabled = true;
            fourButton.Enabled = true;
            fiveButton.Enabled = true;
            sixButton.Enabled = true;
            sevenButton.Enabled = true;
            eightButton.Enabled = true;
            nineButton.Enabled = true;
            backButton.Enabled = true;
            clearButton.Enabled = true;
            addtionButton.Enabled = true;
            subtractButton.Enabled = true;
            multiplicationButton.Enabled = true;
            divisionButton.Enabled = true;
            resultButton.Enabled = true;
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (!outputTextBox.Text.Contains("."))
            {
                outputTextBox.Text += ".";
                outputTextBox.ForeColor = Color.Red;
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text += 0;
            outputTextBox.ForeColor = Color.Red;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text += 1;
            outputTextBox.ForeColor = Color.Red;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text += 2;
            outputTextBox.ForeColor = Color.Red;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text += 3;
            outputTextBox.ForeColor = Color.Red;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text += 4;
            outputTextBox.ForeColor = Color.Red;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text += 5;
            outputTextBox.ForeColor = Color.Red;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text += 6;
            outputTextBox.ForeColor = Color.Red;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text += 7;
            outputTextBox.ForeColor = Color.Red;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text += 8;
            outputTextBox.ForeColor = Color.Red;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text += 9;
            outputTextBox.ForeColor = Color.Red;
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            Disable();
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            Enable();
        }

        public void Compute()
        {
            switch (count)
            {
                case 1:
                    answer = number + float.Parse(outputTextBox.Text);
                    outputTextBox.Text = number.ToString()+"+"+outputTextBox.Text+"="+answer.ToString();
                    break;
                case 2:
                    answer = number - float.Parse(outputTextBox.Text);
                    outputTextBox.Text = answer.ToString();
                    break;
                case 3:
                    answer = number * float.Parse(outputTextBox.Text);
                    outputTextBox.Text = answer.ToString();
                    break;
                case 4:
                    answer = number / float.Parse(outputTextBox.Text);
                    outputTextBox.Text = answer.ToString();
                    break;
                default:
                    break;
            }
        }

        private void addtionButton_Click(object sender, EventArgs e)
        {
            number = float.Parse(outputTextBox.Text);
            outputTextBox.Clear();
            outputTextBox.Focus();
            count = 1;
            displayLabel.Text = number.ToString() + "+";
            displayLabel.ForeColor = Color.Red;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            number = float.Parse(outputTextBox.Text);
            outputTextBox.Clear();
            outputTextBox.Focus();
            count = 2;
            displayLabel.Text = number.ToString() + "-";
            displayLabel.ForeColor = Color.Red;
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            number = float.Parse(outputTextBox.Text);
            outputTextBox.Clear();
            outputTextBox.Focus();
            count = 3;
            displayLabel.Text = number.ToString() + "*";
            displayLabel.ForeColor = Color.Red;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            number = float.Parse(outputTextBox.Text);
            outputTextBox.Clear();
            outputTextBox.Focus();
            count = 4;
            displayLabel.Text = number.ToString() + "/";
            displayLabel.ForeColor = Color.Red;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            Compute();
            displayLabel.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            int length = outputTextBox.TextLength - 1;
            string text = outputTextBox.Text;
            outputTextBox.Clear();
            for (int i = 0; i < length; i++)
            {
                outputTextBox.Text += text[i];
            }
        }

        //private void outputTextBox_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
