using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LaPizza.Classes
{
    public class Util
    {
        public void LimparTextBox(Control.ControlCollection controles)
        {
            foreach(Control c in controles)
            {
                RecursivaLimparTextBox(c);
            }
        }

        public void RecursivaLimparTextBox(Control controle)
        {
            foreach(Control c in controle.Controls)
            {
                if (c is TextBox)
                    c.Text = String.Empty;
                if (c.HasChildren)
                    RecursivaLimparTextBox(c);
            }

        }
    }
}
