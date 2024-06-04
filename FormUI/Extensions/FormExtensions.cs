using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI.Extensions
{
    public static  class FormExtensions
    {
        public static List<TextBox> GetAllTextBox(this Form form)
        {
            var textBoxs = new List<TextBox>();

            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBoxs.Add(textBox);
                }
            }

            return textBoxs;
        }
    }
}
