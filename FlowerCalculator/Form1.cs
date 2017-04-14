using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerCalculator
{
    public partial class Form1 : Form
    {
        private decimal value;
        private int qty;
        private decimal discount;

        FlowerCalculator calculator;

        public Form1()
        {
            InitializeComponent();
            qty = 1;
            discount = 0;
            enableClipboardBtn(false);
        }

        private void marketPrice_Enter(object sender, EventArgs e)
        {
            setPriceText(marketPrice, marketPrice.Text.Replace("$", ""));
            setPriceText(marketPrice, marketPrice.Text.Replace(",", ""));
            EmpyTotal();
        }

        private void marketPrice_Leave(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(marketPrice.Text, out value)) {
                MessageBox.Show("That's not a valid number");
            }
            setPriceText(marketPrice, formatCurrency(value));
        }

        private void discountNumeric_ValueChanged(object sender, EventArgs e)
        {
            EmpyTotal();
            discount = (discountNumeric.Value / 100);
        }

        private void Flower_Qty_ValueChanged(object sender, EventArgs e)
        {
            EmpyTotal();
            qty = (int)Flower_Qty.Value;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            calculator = new FlowerCalculator(qty, value, discount);
            setPriceText(sellPrice, formatCurrency(calculator.Total()));
            enableClipboardBtn(true);
        }
        
        private void copyClipboard_Click(object sender, EventArgs e)
        {
            string clipboard = "Market Price: " + marketPrice.Text + " Quantities: " + calculator.Qty;

            if (calculator.Discount > 0)
            {
                clipboard += " Subtotal: " + formatCurrency(calculator.SubTotal());
                clipboard += " minus " + discountNumeric.Value + "% of discount ";
            }
            else
                clipboard += " no discount ";

            clipboard += "for a total of: " + formatCurrency(calculator.Total());
            Clipboard.SetText(clipboard);
            this.Text = "Copied!!!";
            System.Threading.Thread.Sleep(1000);
            this.Text = "Gabe's Flower Calculator";
        }

        private void setPriceText(TextBox textField, string str)
        {
            textField.Text = str;
        }

        private string formatCurrency(decimal val)
        {
            return string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C0}", val);
        }

        private void EmpyTotal()
        {
            setPriceText(sellPrice, String.Empty);
            enableClipboardBtn(false);
        }

        private void enableClipboardBtn(bool state)
        {
            copyClipboard.Enabled = state;
        }
    }
}
