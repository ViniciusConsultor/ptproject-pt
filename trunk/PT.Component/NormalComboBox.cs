using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace PT.Component
{
    public class NormalComboBox : DevComponents.DotNetBar.Controls.ComboBoxEx
    {
        protected override void OnBindingContextChanged(EventArgs e)
        {           
            base.OnBindingContextChanged(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{tab}");
            base.OnKeyDown(e);
        }
    }
}
