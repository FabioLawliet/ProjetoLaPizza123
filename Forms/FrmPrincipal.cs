using System;
using System.Windows.Forms;
using LaPizza.Forms;
using LaPizza.Classes;

namespace LaPizza
{
    public partial class FrmPrincipal : Form
    {
        public static InteracaoMenu SubMenu;
        public FrmPrincipal()
        {
            InitializeComponent();
            SubMenu = new InteracaoMenu();
            SubMenu.EscondeTodos(pnlMenus.Controls);

        }

        private void btnMenuCliente_Click(object sender, EventArgs e)
        {
            SubMenu.MostraOuEsconde(pnlSubMenuCliente);
        }

        private void btnMenuVenda_Click(object sender, EventArgs e)
        {
            SubMenu.MostraOuEsconde(pnlSubMenuVenda);
        }

        private void btnMenuEstoque_Click(object sender, EventArgs e)
        {
            SubMenu.MostraOuEsconde(pnlSubMenuEstoque);
        }

        private void btnMenuFornecedor_Click(object sender, EventArgs e)
        {
            SubMenu.MostraOuEsconde(pnlSubMenuFornecedor);
        }

        private void btnMenuUsuario_Click(object sender, EventArgs e)
        {
            SubMenu.MostraOuEsconde(pnlSubMenuUsuario);
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

        private void btnSMCliCadastro_Click(object sender, EventArgs e)
        {
            FrmBaseCadastro fc = new FrmBaseCadastro();
            fc.Show();
        }
    }
}
