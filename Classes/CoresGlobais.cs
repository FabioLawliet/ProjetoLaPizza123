using System;
using System.Windows.Forms;

namespace LaPizza.Classes
{
    public class CoresGlobais
    {
        // MENU: Cor do Paineis.
        public static string CorMenuLateral { get; private set; }
        public static string CorMenuLogo { get; private set; }
        public static string CorPainelRotina { get; private set; }

        // MENU: Cor dos Botões.
        public static string CorBtnMenu { get; private set; }
        public static string CorBtnSubMenu { get; private set; }

        // MENU: Cores das Fontes.
        public static string CorFontBtnMenu { get; private set; }
        public static string CorFontBtnSubMenu { get; private set; }

        // FORM: Cores do Formulário.
        public static string CorFormFont { get; private set; }
        public static string CorForm { get; private set; }
        public static string CorFormTextBox { get; private set; }
        public static string CorFormCaption { get; private set; }
        public static string CorFormFocus { get; private set; }
        public void recursiva(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {
                if (c is Button && c.Name.Contains("btnMenu"))
                {
                    c.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    c.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                }
                else if (c is Button && c.Name.Contains("btnSM"))
                {
                    c.BackColor = System.Drawing.Color.FromArgb(180, 0, 255);
                    c.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                }
                if (c.HasChildren)
                {
                    recursiva(c);
                }
            }
        }

        public void ModoEscuro(Control.ControlCollection controles)        
        {
            foreach(Control c in controles)
            {
                recursiva(c);                
            }

            /*
            foreach(Control c in controles){
                if (c is Button)
                {
                    c.BackColor = System.Drawing.Color.FromArgb(255, 246, 0);
                }
                if (c.HasChildren)
                    ModoEscuro(c);
            }
            CorMenuLateral  = "#191919";
            CorMenuLogo     = "#8b0000";
            CorPainelRotina = "#8b0000";
            CorBtnMenu      = "#191919";
            CorBtnSubMenu   = "#323232";
            CorFontBtnMenu = "#fff600";
            CorFontBtnSubMenu = "#ffffff";

            /*
            CorMenuLateral = "#1f1f1f";
            CorMenuLogo = "#ffffff";
            ColorMenuBtnStatic = "#424242";
            ColorMenuBtnClick = "#ff5863";
            ColorMenuBtnHouver = "#ac1e27";
            ColorMenuFont = "#ffffff";
            ColorFormFont = "#000000";*/
        }

    }
}
