using System.Data;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string partial;
        string All;
        string forComputation;

        bool decimalUsed = false;
        bool clearEqual = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void RemoveLeadingZeros()
        {
            if (output.Text.Length > 1 && output.Text.StartsWith("0") && !output.Text.StartsWith("0."))
            {
                output.Text = output.Text.TrimStart('0');

                if (output.Text == "")
                    output.Text = "0";
            }

        }

        private void RemoveEndZeroDeci()
        {
            if (output.Text.Contains('.') && output.Text.EndsWith('0'))
            {
                output.Text = output.Text.TrimEnd('0');
            }

            if (output.Text.EndsWith('.'))
            {
                output.Text = output.Text.TrimEnd('.');
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!clearEqual)
            {
                output.ForeColor = Color.White;
                output.Text += "0";
                RemoveLeadingZeros();

            }
            else
            {
                output.Text = "0";
                clearEqual = false;
                output.ForeColor = Color.White;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!clearEqual)
            {
                output.ForeColor = Color.White;
                output.Text += "1";
                RemoveLeadingZeros();

            }
            else
            {
                output.Text = "1";
                clearEqual = false;
                output.ForeColor = Color.White;
            }
        }

        private void buttonDeci_Click(object sender, EventArgs e)
        {
            if (clearEqual == true)
            {
                output.Text = "";
                AllOps.Text = "";
                clearEqual = false;
            }

            if (!decimalUsed)
            {
                if (output.Text == "")
                {
                    output.Text += "0.";
                    decimalUsed = true;
                }
                else
                {
                    output.Text += ".";
                }
            }

            decimalUsed = true;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (output.Text.Length > 0)
            {
                output.Text = output.Text.Substring(0, output.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!clearEqual)
            {
                output.ForeColor = Color.White;
                output.Text += "2";
                RemoveLeadingZeros();

            }
            else
            {
                output.Text = "2";
                clearEqual = false;
                output.ForeColor = Color.White;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!clearEqual)
            {
                output.ForeColor = Color.White;
                output.Text += "3";
                RemoveLeadingZeros();

            }
            else
            {
                output.Text = "3";
                clearEqual = false;
                output.ForeColor = Color.White;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!clearEqual)
            {
                output.ForeColor = Color.White;
                output.Text += "4";
                RemoveLeadingZeros();

            }
            else
            {
                output.Text = "4";
                clearEqual = false;
                output.ForeColor = Color.White;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!clearEqual)
            {
                output.ForeColor = Color.White;
                output.Text += "5";
                RemoveLeadingZeros();

            }
            else
            {
                output.Text = "5";
                clearEqual = false;
                output.ForeColor = Color.White;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!clearEqual)
            {
                output.ForeColor = Color.White;
                output.Text += "6";
                RemoveLeadingZeros();

            }
            else
            {
                output.Text = "6";
                clearEqual = false;
                output.ForeColor = Color.White;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            output.Text = "";
            AllOps.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!clearEqual)
            {
                output.ForeColor = Color.White;
                output.Text += "7";
                RemoveLeadingZeros();

            }
            else
            {
                output.Text = "7";
                clearEqual = false;
                output.ForeColor = Color.White;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!clearEqual)
            {
                output.ForeColor = Color.White;
                output.Text += "8";
                RemoveLeadingZeros();

            }
            else
            {
                output.Text = "8";
                clearEqual = false;
                output.ForeColor = Color.White;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!clearEqual)
            {
                output.ForeColor = Color.White;
                output.Text += "9";
                RemoveLeadingZeros();

            }
            else
            {
                output.Text = "9";
                clearEqual = false;
                output.ForeColor = Color.White;
            }
        }

        private bool addOperation()
        {
            return !string.IsNullOrWhiteSpace(output.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!addOperation()) return;

            RemoveEndZeroDeci();

            if (double.TryParse(output.Text, out double number))
            {
                All = AllOps.Text + output.Text;
                output.Text = "";
                AllOps.Text = All + " + ";
                forComputation = All + " + ";
                decimalUsed = false;
            }
            else
            {
                output.Text = "";
                AllOps.Text = "";
                clearEqual = false;
            }

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (!addOperation()) return;

            RemoveEndZeroDeci();

            if (double.TryParse(output.Text, out double number))
            {
                All = AllOps.Text + output.Text;
                output.Text = "";
                AllOps.Text = All + " - ";
                forComputation = All + " - ";
                decimalUsed = false;
            }
            else
            {
                output.Text = "";
                AllOps.Text = "";
                clearEqual = false;
            }


        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (!addOperation()) return;

            RemoveEndZeroDeci();

            if (double.TryParse(output.Text, out double number))
            {
                All = AllOps.Text + output.Text;
                output.Text = "";
                AllOps.Text = All + " * ";
                forComputation = All + " * ";
                decimalUsed = false;
            }
            else
            {
                output.Text = "";
                AllOps.Text = "";
                clearEqual = false;
            }


        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (!addOperation()) return;

            RemoveEndZeroDeci();

            if (double.TryParse(output.Text, out double number))
            {
                All = AllOps.Text + output.Text;
                output.Text = "";
                AllOps.Text = All + " ÷ ";
                forComputation = All + " / ";
                decimalUsed = false;
            }
            else
            {
                output.Text = "";
                AllOps.Text = "";
                clearEqual = false;
            }

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            clearEqual = true;

            if (string.IsNullOrWhiteSpace(output.Text)) return;

            if (forComputation != null && forComputation.TrimEnd().EndsWith("/") && output.Text == "0")
            {
                AllOps.Text = "";
                output.Text = "Cannot divide by zero";
                output.ForeColor = Color.Red;
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(forComputation) || !decimal.TryParse(output.Text, out _))
                {
                    return;
                }

                // Combine full expression
                string expression = forComputation + output.Text;

                // Compute result (MDAS respected)
                DataTable table = new DataTable();
                var result = table.Compute(expression, "");

                if (string.IsNullOrWhiteSpace(AllOps.Text))
                {
                    return;
                }
                // Show result
                output.Text = result.ToString();
                forComputation = "";


                // Reset for next input
                decimalUsed = output.Text.Contains(".");

                AllOps.Text = "";
                RemoveEndZeroDeci();

            }
            catch
            {
                output.Text = "Error";
                output.ForeColor = Color.Red;
                AllOps.Text = "";
                decimalUsed = false;
            }
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(output.Text, out decimal num))
                return;

            output.Text = (-num).ToString();
        }

        private void AllOps_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
