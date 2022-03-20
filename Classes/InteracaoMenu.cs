using System.Windows.Forms;
using System;

namespace LaPizza.Classes
{
    public class InteracaoMenu
    {

        
        public void SubMenuMostrarOuEsconder(Panel subMenu)
        {
            if (subMenu.Visible == false)
                subMenu.Visible = true;
            else
                subMenu.Visible = false;
        }
        
        public void SubMenuEsconderTodos(Control.ControlCollection Controls)
        {
           foreach(Control ctr in Controls)
                if (ctr is Panel)
                    if (ctr.Name.Contains("pnlSubMenu"))
                        ctr.Visible = false;
        }

    }
}
