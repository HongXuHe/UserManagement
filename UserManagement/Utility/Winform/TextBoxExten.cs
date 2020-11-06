using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace UserManagement.Utility.Winform
{
    public static class TextBoxExten
    {
        public static string TrimString(this TextBox textBox)
        {
            if(textBox != null)
            {
                var res = textBox.Text.TrimStart().TrimEnd();
                return res;
            }
            return string.Empty;
        }
    }
}
