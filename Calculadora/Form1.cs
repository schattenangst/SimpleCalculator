using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private bool isMinus;
        private decimal firstValue = 0;
        private decimal secondValue = 0;
        private decimal? memory = null;
        private string typeOperation = string.Empty;

        Operations operation = new Operations();

        public Form1()
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

            if (!string.IsNullOrEmpty(numberText))
            {
                value = decimal.Parse(TextValue.Text);
            }

            return value;
        }
    }
}