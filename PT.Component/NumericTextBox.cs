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
            //this.Text = "0";
            RightToLeft = RightToLeft.Yes;
            base.OnBindingContextChanged(e);
        }

        //protected override void OnLeave(EventArgs e)
        //{
        //    string str1 = this.Text.ToString();
        //    string str2 = str1.Replace(",", null);
        //    float a;
        //    bool kq = float.TryParse(str2, out a);
        //    this.Text = a.ToString("0,0", CultureInfo.InvariantCulture);
        //    base.OnLeave(e);
        //}

        protected override void OnTextChanged(EventArgs e)
        {
           // base.OnTextChanged(e);

            //string str1 = this.Text.ToString();
            //if (str1.Length == 4)
            //{
            //    str1 = str1.Substring(0, 3) + "," + str1.Substring(3, 1);
            //    Text = str1;
            //}
            //this.fo
            

            //TextBox t = (TextBox)sender;

            String Text = this.Text.ToString();
            //int selStart = t.SelectionStart;
            int commaCount_Before = 0;
            int commaCount_After = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text.Substring(i, 1) == ",")
                {
                    commaCount_Before++;
                }
            }
            float Num;
            Text = Text.Replace(",", "");
            if (float.TryParse(Text, out Num))
            {
                Text = String.Format("{0:N0}", Num);
                this.Text = Text;
            }
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text.Substring(i, 1) == ",")
                {
                    commaCount_After++;
                }
            }

            this.SelectionStart = Text.Length;
            //int diff = (commaCount_After - commaCount_Before);
            //if (diff>=0)
            //    this.SelectionStart = selStart + (commaCount_After - commaCount_Before);
            ////{
            //    t.SelectionStart = selStart + (commaCount_After - commaCount_Before);
            //}

        }


        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string groupSeparator = numberFormatInfo.NumberGroupSeparator;
            string negativeSign = numberFormatInfo.NegativeSign;

            string keyInput = e.KeyChar.ToString();

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
    }
}
