using System;
using System.Windows.Forms;
using LaPizza.Forms;
using LaPizza.Classes;

namespace LaPizza
{
    public partial class FmrPrincipal : Form
    {
        public static InteracaoMenu Menu;

        private FmrCadastroCliente FmrCliente;
        public FmrPrincipal()
        {
            InitializeComponent();
            Menu = new InteracaoMenu();
            Menu.SubMenuEsconderTodos(pnlMenus.Controls);

        }

        private void seila()
        {
            /*
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    MessageBox.Show(c.Name);
                }
                if (c.HasChildren)
                    seila(c);
            }
           
            /*
            if (FmrCliente == null || FmrCliente.IsDisposed)
            {
                FmrCliente = new FmrCadastroCliente();
                FmrCliente.TopLevel = false;
                FmrCliente.Visible = true;
                pnlRotinas.Controls.Add(FmrCliente);
            }else
            {
                FmrCliente.BringToFront();
            }*/

        }

        private void btnMenuCliente_Click(object sender, EventArgs e)
        {
            Menu.SubMenuMostrarOuEsconder(pnlSubMenuCliente);
        }

        private void btnMenuVenda_Click(object sender, EventArgs e)
        {
            Menu.SubMenuMostrarOuEsconder(pnlSubMenuVenda);
        }

        private void btnMenuEstoque_Click(object sender, EventArgs e)
        {
            Menu.SubMenuMostrarOuEsconder(pnlSubMenuEstoque);
        }

        private void btnMenuFornecedor_Click(object sender, EventArgs e)
        {
            Menu.SubMenuMostrarOuEsconder(pnlSubMenuFornecedor);
        }

        private void btnMenuUsuario_Click(object sender, EventArgs e)
        {
            Menu.SubMenuMostrarOuEsconder(pnlSubMenuUsuario);
        }
    }
}
