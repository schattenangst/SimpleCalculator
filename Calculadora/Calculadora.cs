
namespace Calculadora
{
    using Common.Contracts;
    using Common.Entities;
    using Service.Implementations;
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class Calculadora : Form
    {
        private bool isMinus;
        private decimal firstValue = 0;
        private decimal secondValue = 0;
        private decimal? memory = null;
        private string typeOperation = string.Empty;

        IOperations operation = new Operations();

        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            firstValue = GetValueText("+");
        }

        private void Substraction_Click(object sender, EventArgs e)
        {
            firstValue = GetValueText("-");
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            firstValue = GetValueText("*");
        }

        private void Division_Click(object sender, EventArgs e)
        {
            firstValue = GetValueText("/");
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextValue.Text))
            {
                isMinus = !isMinus;

                string newValue = string.Empty;

                if (isMinus)
                {
                    newValue = $"-{TextValue.Text}";
                }
                else
                {
                    newValue = TextValue.Text.Replace("-", string.Empty);
                }

                TextValue.Text = newValue;
            }
        }

        /// <summary>
        /// Obtiene el valor actual
        /// </summary>
        /// <returns></returns>
        private decimal GetValueText(string operation)
        {
            decimal value = 0;

            if (!string.IsNullOrEmpty(TextValue.Text))
            {
                value = GetValueParseText(TextValue.Text);

                if (!string.IsNullOrEmpty(operation))
                {
                    typeOperation = operation;
                    TextShow.Text = $"{value}{operation}";
                    TextValue.Text = string.Empty;
                    TextValue.Focus();
                }
            }

            return value;
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            firstValue = 0;
            secondValue = 0;
            TextValue.Text = string.Empty;
            TextShow.Text = string.Empty;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            MessageResponse<decimal> response;
            secondValue = GetValueText(string.Empty);
            response = operation.GetResultOperation(firstValue, secondValue, typeOperation);

            if (!response.IsError)
            {
                TextValue.Text = response.Response.ToString();
                TextShow.Text = string.Empty;
            }
            else
            {
                TextValue.Text = response.Message;
            }
        }

        private void AddMemory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextValue.Text))
            {
                memory = (memory ?? 0) + GetValueParseText(TextValue.Text);
                MemoryLabel.Visible = true;
            }
        }

        private void RemoveMemory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextValue.Text))
            {
                memory = (memory ?? 0) - GetValueParseText(TextValue.Text);
                MemoryLabel.Visible = true;
            }
        }

        private void TotalMemory_Click(object sender, EventArgs e)
        {
            if (memory != null)
            {
                TextValue.Text = memory.ToString();
                MemoryLabel.Visible = true;
            }
        }

        private void CleanMemory_Click(object sender, EventArgs e)
        {
            MemoryLabel.Visible = false;
            memory = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberText"></param>
        /// <returns></returns>
        private decimal GetValueParseText(string numberText)
        {
            decimal value = 0;

            if (!string.IsNullOrEmpty(numberText) && !decimal.TryParse(numberText, out value))
            {
                TextValue.Text = "Sintaxis Error";
            }

            return value;
        }

        private void Calculadora_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextValue_TextChanged(object sender, EventArgs e)
        {
            GetValueParseText(((TextBox)sender).Text);
        }

        private void Number_Click(object sender, EventArgs e)
        {
            string value = string.Empty;

            value = $"{TextValue.Text}{(sender as Button).Text}";
            Regex exp = new Regex(@"^[0-9]+([.])?([0-9]+)?$");

            if (exp.IsMatch(value))
            {
                TextValue.Text = value;
            }
        }
    }
}