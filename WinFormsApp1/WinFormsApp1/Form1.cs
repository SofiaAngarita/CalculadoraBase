﻿using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string currentOperation = "";
        bool isUnaryOperation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int entero = Convert.ToInt16(enteroTXT.Text);
                ResultLB.Text = "si es un numero";
            }
            catch (Exception ex)
            {
                ResultLB.Text = "no es un numero";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentOperation = "^";
            enteroTXT.Text += "^";
        }

        private void button10_Click(object sender, EventArgs e)
        {

            {
                enteroTXT.Text += "2";
            };


        }

        private void button14_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "8";
        }

        private void ComprobarBTN_Click(object sender, EventArgs e)
        {
            enteroTXT.Text = string.Empty;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += ".";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "+";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "4";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentOperation = "√";
            isUnaryOperation = true;  // Marcamos que es una operación unaria
            enteroTXT.Text += "√";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUnaryOperation)
                {
                    switch (currentOperation)
                    {
                        case "√":
                            double num = Double.Parse(enteroTXT.Text.Replace("√", ""));
                            enteroTXT.Text = Math.Sqrt(num).ToString();
                            break;
                        case "%":
                            double numPercentage = Double.Parse(enteroTXT.Text.Replace("%", ""));
                            enteroTXT.Text = (numPercentage / 100).ToString();
                            break;
                        default:
                            enteroTXT.Text = "Operación no reconocida";
                            break;
                    }
                }
                else
                {
                    // Si es potenciación, la manejamos aquí. 
                    if (currentOperation == "^")
                    {
                        string[] numbers = enteroTXT.Text.Split('^');
                        if (numbers.Length == 2)
                        {
                            double baseNumber = Double.Parse(numbers[0]);
                            double exponent = Double.Parse(numbers[1]);
                            enteroTXT.Text = Math.Pow(baseNumber, exponent).ToString();
                        }
                    }
                    else
                    {
                        DataTable table = new DataTable();
                        enteroTXT.Text = table.Compute(enteroTXT.Text, String.Empty).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                enteroTXT.Text = "Error";
            }

            currentOperation = "";
            isUnaryOperation = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentOperation = "%";
            isUnaryOperation = true; // Marcamos que es una operación unaria
            enteroTXT.Text += "%";
        }
    }
}