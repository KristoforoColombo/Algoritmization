using System.Data;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string currentOperation = "";
        private double firstNumber = 0;
        private bool isSecondNumber = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void n_0_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "0" && pole_vvoda.Text != null)
                pole_vvoda.Text = "0";
            else
                pole_vvoda.Text += "0";
        }

        private void n_1_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "0" && pole_vvoda.Text != null)
                pole_vvoda.Text = "1";
            else
                pole_vvoda.Text += "1";
        }

        private void n_2_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "0" && pole_vvoda.Text != null)
                pole_vvoda.Text = "2";
            else
                pole_vvoda.Text += "2";
        }

        private void n_3_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "0" && pole_vvoda.Text != null)
                pole_vvoda.Text = "3";
            else
                pole_vvoda.Text += "3";
        }

        private void n_4_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "0" && pole_vvoda.Text != null)
                pole_vvoda.Text = "4";
            else
                pole_vvoda.Text += "4";
        }

        private void n_5_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "0" && pole_vvoda.Text != null)
                pole_vvoda.Text = "5";
            else
                pole_vvoda.Text += "5";
        }

        private void n_6_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "0" && pole_vvoda.Text != null)
                pole_vvoda.Text = "6";
            else
                pole_vvoda.Text += "6";
        }

        private void n_7_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "0" && pole_vvoda.Text != null)
                pole_vvoda.Text = "7";
            else
                pole_vvoda.Text += "7";
        }

        private void n_8_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "0" && pole_vvoda.Text != null)
                pole_vvoda.Text = "8";
            else
                pole_vvoda.Text += "8";
        }

        private void n_9_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "0" && pole_vvoda.Text != null)
                pole_vvoda.Text = "9";
            else
                pole_vvoda.Text += "9";
        }

        private void n_plus_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "")
                pole_vvoda.Text = "0+";
            else
                pole_vvoda.Text += "+";
        }

        private void n_minus_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "")
                pole_vvoda.Text = "-";
            else
                pole_vvoda.Text += "-";
        }

        private void n_umnog_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "")
                pole_vvoda.Text = "0*";
            else
                pole_vvoda.Text += "*";
        }

        private void n_delit_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "")
                pole_vvoda.Text = "0/";
            else
                pole_vvoda.Text += "/";
        }

        private void n_zapytaya_Click(object sender, EventArgs e)
        {
            if (pole_vvoda.Text == "")
                pole_vvoda.Text = "0,";
            else
                pole_vvoda.Text += ",";
        }

        private void n_ravno_Click(object sender, EventArgs e)
        {
            try
            {

                string expression = pole_vvoda.Text.Replace(",", ".");

                if (expression.Contains("Mod"))
                {
                    string[] parts = expression.Split(new[] { "Mod" }, StringSplitOptions.None);
                    if (parts.Length == 2)
                    {
                        double leftOperand = Convert.ToDouble(parts[0].Trim());
                        double rightOperand = Convert.ToDouble(parts[1].Trim());
                        double result = leftOperand % rightOperand;
                        pole_vvoda.Text = result.ToString().Replace(".", ",");
                        return;
                    }
                    else
                    {
                        throw new Exception("Некорректное выражение для операции Mod!");
                    }
                }

                else if (expression.Contains("^"))
                {
                    string[] parts = expression.Split('^');
                    if (parts.Length == 2)
                    {
                        double baseValue = Convert.ToDouble(parts[0].Trim());
                        double exponent = Convert.ToDouble(parts[1].Trim());
                        double result = Math.Pow(baseValue, exponent);
                        pole_vvoda.Text = result.ToString().Replace(".", ",");
                        return;
                    }
                    else
                    {
                        throw new Exception("Некорректное выражение для возведения в степень!");
                    }
                }

                else
                {
                    var table = new DataTable();
                    var result = table.Compute(expression, null);
                    pole_vvoda.Text = result.ToString().Replace(".", ",");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в выражении!");
                pole_vvoda.Text = "0";
            }
        }

   


        private void n_chistka_Click(object sender, EventArgs e)
        {
            pole_vvoda.Text = "";
        }
        private void n_chistka_1_Click(object sender, EventArgs e)
        {
            pole_vvoda.Text = pole_vvoda.Text.Substring(0, pole_vvoda.Text.Length - 1);
        }

        private void n_e_Click(object sender, EventArgs e)
        {
            pole_vvoda.Text += Math.E.ToString();
        }

        private void n_pi_Click(object sender, EventArgs e)
        {
            pole_vvoda.Text += Math.PI.ToString();
        }

        private void n_ln_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(pole_vvoda.Text);
                pole_vvoda.Text = Math.Log(value).ToString();
            }
            catch
            {
                pole_vvoda.Text = "Ошибка";
            }
        }

        private void n_log_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(pole_vvoda.Text);
                pole_vvoda.Text = Math.Log10(value).ToString();
            }
            catch
            {
                pole_vvoda.Text = "Ошибка";
            }
        }

        private void n_10_to_x_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(pole_vvoda.Text);
                pole_vvoda.Text = Math.Pow(10, value).ToString();
            }
            catch
            {
                pole_vvoda.Text = "Ошибка";
            }
        }

        private void n_x_to_y_Click(object sender, EventArgs e)
        {
            pole_vvoda.Text += "^";  // Assuming "^" represents the power operator in the input.
        }

        private void n_sqrt_x_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(pole_vvoda.Text);
                pole_vvoda.Text = Math.Sqrt(value).ToString();
            }
            catch
            {
                pole_vvoda.Text = "Ошибка";
            }
        }

        private void n_x_to_2_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(pole_vvoda.Text);
                pole_vvoda.Text = Math.Pow(value, 2).ToString();
            }
            catch
            {
                pole_vvoda.Text = "Ошибка";
            }
        }

        private void n_1_del_x_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(pole_vvoda.Text);
                pole_vvoda.Text = (1 / value).ToString();
            }
            catch
            {
                pole_vvoda.Text = "Ошибка";
            }
        }

        private void n_modul_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(pole_vvoda.Text);
                pole_vvoda.Text = Math.Abs(value).ToString();
            }
            catch
            {
                pole_vvoda.Text = "Ошибка";
            }
        }

        private void n_exp_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(pole_vvoda.Text);
                pole_vvoda.Text = Math.Exp(value).ToString();
            }
            catch
            {
                pole_vvoda.Text = "Ошибка";
            }
        }

        private void n_mod_Click(object sender, EventArgs e)
        {
            int cursorPosition = pole_vvoda.SelectionStart;
            pole_vvoda.Text = pole_vvoda.Text.Insert(cursorPosition, "Mod");
            pole_vvoda.SelectionStart = cursorPosition + 3;
        }

        private void n_factorial_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(pole_vvoda.Text);
                int factorial = 1;
                for (int i = 1; i <= value; i++)
                    factorial *= i;
                pole_vvoda.Text = factorial.ToString();
            }
            catch
            {
                pole_vvoda.Text = "Ошибка";
            }
        }

        private void n_open_scob_Click(object sender, EventArgs e)
        {
            pole_vvoda.Text += "(";
        }

        private void n_close_scob_Click(object sender, EventArgs e)
        {
            pole_vvoda.Text += ")";
        }

    }
}
