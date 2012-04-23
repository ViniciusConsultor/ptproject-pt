using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using PT.Helper;

namespace PT.Component
{
    public class NormalLabel: DevComponents.DotNetBar.LabelX
    {
        protected override void OnBindingContextChanged(EventArgs e)
        {            
            base.OnBindingContextChanged(e);
        }
        protected override void  OnCreateControl()
        {
            if (System.IO.File.Exists(Globals.PTXMLLanguage) == true)
            {
                this.Text = Utility.ChangeLanguage(this.Text, Globals.PTLanguage);
            }
            base.InitLayout();

        }
        //public override void  Refresh()
        //{
        //    this.Text = Utility.ChangeLanguage(this.Text, Globals.PTLanguage);
        //    base.OnCreateControl();
        //}
    }
}
