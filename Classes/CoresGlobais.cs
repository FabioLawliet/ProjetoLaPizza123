using System;
using System.Collections.Generic;
using System.Text;

namespace LaPizza.Classes
{
    public class CoresGlobais
    {
        // MENU: Cor do Paineis.
        public string CorMenuLateral { get; private set; }
        public string CorMenuLogo { get; private set; }

        // MENU: Cor dos botões.
        public string ColorMenuBtnStatic { get; private set; }
        public string ColorMenuBtnClick { get; private set; }
        public string ColorMenuBtnHouver { get; private set; }

        // MENU: Cores das fontes.
        public string ColorMenuFont { get; private set; }

        // FORM: Cores do Formulário.
        public string ColorFormFont { get; private set; }
        public string ColorForm { get; private set; }
        public string ColorFormTextBox { get; private set; }
        public string ColorFormCaption { get; private set; }
        public string ColorFormFocus { get; private set; }


        public void ModoDark()
        {
            CorMenuLateral = "#1f1f1f";
            CorMenuLogo = "#ffffff";
            ColorMenuBtnStatic = "#424242";
            ColorMenuBtnClick = "#ff5863";
            ColorMenuBtnHouver = "#ac1e27";
            ColorMenuFont = "#ffffff";
            ColorFormFont = "#000000";
        }

    }
}
