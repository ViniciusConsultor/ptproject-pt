using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace PT.Component
{
    public class NumericTextBox : DevComponents.DotNetBar.Controls.TextBoxX
    {
        bool allowSpace = false;

        // Restricts the entry of characters to digits (including hex), the negative sign,
        // the decimal point, and editing keystrokes (backspace).

        protected override void OnBindingContextChanged(EventArgs e)
        {
            TextAlign = HorizontalAlignment.Right;            
            base.OnBindingContextChanged(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{tab}");
            base.OnKeyDown(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            String Text = this.Text.ToString();
            Double Num;
            if((Text.Length >0) && (Text.Substring(Text.Length - 1, 1) != "."))
            {
                if (Double.TryParse(Text, out Num))
                {
                    Text = String.Format("{0:#,###.###}", Num);
                    this.Text = Text;
                }
            }
            this.SelectionStart = Text.Length;            
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string groupSeparator = numberFormatInfo.NumberGroupSeparator;
            string negativeSign = numberFormatInfo.NegativeSign;

            string keyInput = e.KeyChar.ToString();
            if ((e.KeyChar == '.') && Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (Text.Length == 0)
            {
                this.SelectionStart = this.Text.Length;
                if ((e.KeyChar == '-') && (Text.LastIndexOf('-') > -1))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (((e.KeyChar == '-') && (Text.IndexOf('-') > -1)) || ((e.KeyChar == '-') && (this.SelectionStart != 0)))
                {
                    e.Handled = true;
                }
            }
            if (Char.IsDigit(e.KeyChar))
            {
                // Digits are OK
            }
            else if (keyInput.Equals(decimalSeparator) || keyInput.Equals(groupSeparator) ||
             keyInput.Equals(negativeSign))
            {
                // Decimal separator is OK
            }
            else if (e.KeyChar == '\b')
            {
                // Backspace key is OK
            }
            //    else if ((ModifierKeys & (Keys.Control | Keys.Alt)) != 0)
            //    {
            //     // Let the edit control handle control and alt key combinations
            //    }
            else if (this.allowSpace && e.KeyChar == ' ')
            {

            }
            else if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {

            }
            else
            {
                // Swallow this invalid key and beep
                e.Handled = true;
                //    MessageBeep();
            }

            
        }
       
        public int IntValue
        {
            get
            {
                return Int32.Parse(this.Text);
            }
        }

        public decimal DecimalValue
        {
            get
            {
                return Decimal.Parse(this.Text);
            }
        }

        public bool AllowSpace
        {
            set
            {
                this.allowSpace = value;
            }

            get
            {
                return this.allowSpace;
            }
        }
        public string Number
        {
            get { return Text.Replace(",", null); }
        }
        public double doubles
        {
            get
            {
                double db;
                db = double.Parse(Text);
                return db;
            }
        }

    }
}
