using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polynomial_Factorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {            
            //check for errors
            if (string.IsNullOrWhiteSpace(coefficientsText.Text))
            {
                MessageBox.Show("ERROR: There is nothing inputted");
                return;
            }            
            else if (string.IsNullOrWhiteSpace(coefficientsText.Text[0].ToString()) || string.IsNullOrWhiteSpace(coefficientsText.Text[coefficientsText.Text.Length - 1].ToString()))
            {
                MessageBox.Show("ERROR: First or last character cannot be a whitespace");
                return;
            }
            foreach (char c in coefficientsText.Text)
            {
                if (char.IsLetter(c))
                {
                    MessageBox.Show("ERROR: Input contains non-numerical values");
                }
            }

            //screen cleanup
            function.Text = null;
            final.Text = "x =";

            //split up the input into a string and double array
            string[] coefs = coefficientsText.Text.Split(' ');

            List<double> coefficients = new List<double>();

            for (int i = 0; i < coefs.Length; i++)
            {
                coefficients.Add(Convert.ToDouble(coefs[i]));
            }

            //print the function to the screen
            int power = coefs.Length - 1;
            for (int i = 0; i < coefs.Length; i++)
            {
                if (power == coefs.Length - 1 && power != 0)
                {
                    function.Text += $"{coefs[i]}x^{power} ";
                }
                else if (power < coefs.Length - 1 && power > 1)
                {
                    if (coefficients.ToArray()[i] > 0)
                    {
                        function.Text += $"+ {coefs[i]}x^{power} ";
                    }
                    else
                    {
                        function.Text += $"- {Math.Abs(coefficients.ToArray()[i])}x^{power} ";
                    }
                }
                else if (power == 1)
                {
                    if (coefficients.ToArray()[i] > 0)
                    {
                        function.Text += $"+ {coefs[i]}x ";
                    }
                    else
                    {
                        function.Text += $"- {Math.Abs(coefficients.ToArray()[i])}x ";
                    }
                }
                else if (power <= 0)
                {
                    if (coefficients.ToArray()[i] > 0)
                    {
                        function.Text += $"+ {coefs[i]} ";
                    }
                    else
                    {
                        function.Text += $"- {Math.Abs(coefficients.ToArray()[i])} ";
                    }
                }

                power--;
            }

            //Find factors, plug them into the function, check to see if it is zero, if so, put it in the answers as an answer
            double[] firstFactors = FindFactors(coefficients.ToArray()[0]);
            double[] lastFactors = FindFactors(coefficients.ToArray()[coefficients.ToArray().Length - 1]);

            if (coefficients.ToArray()[coefficients.ToArray().Length - 1] == 0)
            {
                lastFactors = new double[] { 1d };                
            }

            double answer = 0;
            List<string> roots = new List<string>();

            //trial and error, checking all factors
            foreach (double p in lastFactors)
            {
                foreach (double q in firstFactors)
                {
                    int pow = coefficients.ToArray().Length - 1, num = 0;

                    while (pow >= 0 && num < coefficients.ToArray().Length)
                    {
                        answer += coefficients.ToArray()[num] * Math.Pow(p/q, pow);

                        pow--;
                        num++;
                    }

                    if (showWork.Checked)
                    {
                        MessageBox.Show($"{p / q} = {answer}");
                    }

                    if (answer < 0.00001 && answer > -0.00001)
                    {
                        answer = p / q;

                        if (answer % 1 != 0)
                        {
                            //MessageBox.Show($"new zero (fraction)! {p} / {q}");

                            if (answer > 0 && !roots.Contains($"{Math.Abs(p)}/{Math.Abs(q)}"))
                            {
                                roots.Add($"{Math.Abs(p)}/{Math.Abs(q)}");
                            }
                            else if (answer < 0 && !roots.Contains($"-{Math.Abs(p)}/{Math.Abs(q)}"))
                            {
                                roots.Add($"-{Math.Abs(p)}/{Math.Abs(q)}");
                            }                            
                        }
                        else if (!roots.Contains(answer.ToString()))
                        {
                            //MessageBox.Show($"new zero (integer)! {p} / {q}");
                            roots.Add(answer.ToString());
                        }
                                                
                    }

                    answer = 0;
                }               
            }

            //removes current roots to avoid duplicates does quadratic formula if function is a quadratic and not enough roots have been found
            if (coefficients.Count == 3 && roots.Count < 2)
            {
                roots.Clear();
                roots.Add(Math.Round(((-coefficients[1] + Math.Sqrt(coefficients[1] * coefficients[1] - 4d * coefficients[0] * coefficients[2])) / (2 * coefficients[0])), 10).ToString());
                roots.Add(Math.Round(((-coefficients[1] - Math.Sqrt(coefficients[1] * coefficients[1] - 4d * coefficients[0] * coefficients[2])) / (2 * coefficients[0])), 10).ToString());
            }

            if (roots.Count == 0)
            {
                final.Text += " no real roots or not simple";
            }
            
            //prints roots
            foreach (string s in roots)
            {
                final.Text += $" {s},";
            }

            //takes the comma off the end
            final.Text = final.Text.Substring(0, final.Text.Length - 1);
        }
        public static double[] FindFactors(double d)
        {            
            List<double> f = new List<double>();

            d = Math.Abs(d);

            for (double i = -d; i <= d; i += 1f)
            {
                if (d % i == 0)
                {
                    f.Add(i);
                }
            }
            return f.ToArray();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
