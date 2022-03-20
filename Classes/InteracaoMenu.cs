using System.Windows.Forms;
using System;

namespace LaPizza.Classes
{
    public class InteracaoMenu
    {

        
        public void MostraOuEsconde(Panel subMenu)
        {
            if (subMenu.Visible == false)
                subMenu.Visible = true;
            else
                subMenu.Visible = false;
        }
        
        public void EscondeTodos(Control.ControlCollection controls)
        {
           foreach(Control ctr in controls)
                if (ctr is Panel)
                    if (ctr.Name.Contains("pnlSubMenu"))
                        ctr.Visible = false;
        }

    }
}
