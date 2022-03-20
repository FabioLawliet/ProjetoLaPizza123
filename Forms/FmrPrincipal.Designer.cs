
namespace LaPizza
{
    partial class FmrPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrPrincipal));
            this.pnlRotinas = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMenus = new System.Windows.Forms.Panel();
            this.pnlSubMenuUsuario = new System.Windows.Forms.Panel();
            this.btnUsuPermissoes = new System.Windows.Forms.Button();
            this.btnUsuControleAcesso = new System.Windows.Forms.Button();
            this.btnUsuCadastro = new System.Windows.Forms.Button();
            this.btnMenuUsuario = new System.Windows.Forms.Button();
            this.pnlSubMenuFornecedor = new System.Windows.Forms.Panel();
            this.bntForRelatorio = new System.Windows.Forms.Button();
            this.btnForCadastro = new System.Windows.Forms.Button();
            this.btnMenuFornecedor = new System.Windows.Forms.Button();
            this.pnlSubMenuEstoque = new System.Windows.Forms.Panel();
            this.btnSMEstControle = new System.Windows.Forms.Button();
            this.btnSMEstEntradaMerc = new System.Windows.Forms.Button();
            this.btnSMEstSubGrupo = new System.Windows.Forms.Button();
            this.btnSMEstGrupo = new System.Windows.Forms.Button();
            this.btnSMEstMarca = new System.Windows.Forms.Button();
            this.btnSMEstProduto = new System.Windows.Forms.Button();
            this.btnMenuEstoque = new System.Windows.Forms.Button();
            this.pnlSubMenuVenda = new System.Windows.Forms.Panel();
            this.btnSMVenRelatorio = new System.Windows.Forms.Button();
            this.btnSMVenRegistro = new System.Windows.Forms.Button();
            this.btnSMVenPedido = new System.Windows.Forms.Button();
            this.btnMenuVenda = new System.Windows.Forms.Button();
            this.pnlSubMenuCliente = new System.Windows.Forms.Panel();
            this.btnSMCliRelatorio = new System.Windows.Forms.Button();
            this.btnSMCliCadastro = new System.Windows.Forms.Button();
            this.btnMenuCliente = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlMenus.SuspendLayout();
            this.pnlSubMenuUsuario.SuspendLayout();
            this.pnlSubMenuFornecedor.SuspendLayout();
            this.pnlSubMenuEstoque.SuspendLayout();
            this.pnlSubMenuVenda.SuspendLayout();
            this.pnlSubMenuCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRotinas
            // 
            this.pnlRotinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlRotinas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRotinas.BackgroundImage")));
            this.pnlRotinas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlRotinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRotinas.Location = new System.Drawing.Point(255, 0);
            this.pnlRotinas.Name = "pnlRotinas";
            this.pnlRotinas.Size = new System.Drawing.Size(753, 659);
            this.pnlRotinas.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkRed;
            this.pnlMenu.Controls.Add(this.pnlMenus);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(255, 659);
            this.pnlMenu.TabIndex = 2;
            // 
            // pnlMenus
            // 
            this.pnlMenus.AutoScroll = true;
            this.pnlMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlMenus.Controls.Add(this.pnlSubMenuUsuario);
            this.pnlMenus.Controls.Add(this.btnMenuUsuario);
            this.pnlMenus.Controls.Add(this.pnlSubMenuFornecedor);
            this.pnlMenus.Controls.Add(this.btnMenuFornecedor);
            this.pnlMenus.Controls.Add(this.pnlSubMenuEstoque);
            this.pnlMenus.Controls.Add(this.btnMenuEstoque);
            this.pnlMenus.Controls.Add(this.pnlSubMenuVenda);
            this.pnlMenus.Controls.Add(this.btnMenuVenda);
            this.pnlMenus.Controls.Add(this.pnlSubMenuCliente);
            this.pnlMenus.Controls.Add(this.btnMenuCliente);
            this.pnlMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenus.Location = new System.Drawing.Point(0, 100);
            this.pnlMenus.MaximumSize = new System.Drawing.Size(250, 0);
            this.pnlMenus.Name = "pnlMenus";
            this.pnlMenus.Size = new System.Drawing.Size(250, 559);
            this.pnlMenus.TabIndex = 2;
            // 
            // pnlSubMenuUsuario
            // 
            this.pnlSubMenuUsuario.AutoSize = true;
            this.pnlSubMenuUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlSubMenuUsuario.Controls.Add(this.btnUsuPermissoes);
            this.pnlSubMenuUsuario.Controls.Add(this.btnUsuControleAcesso);
            this.pnlSubMenuUsuario.Controls.Add(this.btnUsuCadastro);
            this.pnlSubMenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuUsuario.Location = new System.Drawing.Point(0, 525);
            this.pnlSubMenuUsuario.Name = "pnlSubMenuUsuario";
            this.pnlSubMenuUsuario.Size = new System.Drawing.Size(233, 75);
            this.pnlSubMenuUsuario.TabIndex = 10;
            // 
            // btnUsuPermissoes
            // 
            this.btnUsuPermissoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUsuPermissoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuPermissoes.FlatAppearance.BorderSize = 0;
            this.btnUsuPermissoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnUsuPermissoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnUsuPermissoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuPermissoes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuPermissoes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuPermissoes.Location = new System.Drawing.Point(0, 50);
            this.btnUsuPermissoes.Name = "btnUsuPermissoes";
            this.btnUsuPermissoes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuPermissoes.Size = new System.Drawing.Size(233, 25);
            this.btnUsuPermissoes.TabIndex = 5;
            this.btnUsuPermissoes.Text = "Controle de Permissões";
            this.btnUsuPermissoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuPermissoes.UseVisualStyleBackColor = false;
            // 
            // btnUsuControleAcesso
            // 
            this.btnUsuControleAcesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUsuControleAcesso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuControleAcesso.FlatAppearance.BorderSize = 0;
            this.btnUsuControleAcesso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnUsuControleAcesso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnUsuControleAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuControleAcesso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuControleAcesso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuControleAcesso.Location = new System.Drawing.Point(0, 25);
            this.btnUsuControleAcesso.Name = "btnUsuControleAcesso";
            this.btnUsuControleAcesso.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuControleAcesso.Size = new System.Drawing.Size(233, 25);
            this.btnUsuControleAcesso.TabIndex = 4;
            this.btnUsuControleAcesso.Text = "Controle de Acesso";
            this.btnUsuControleAcesso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuControleAcesso.UseVisualStyleBackColor = false;
            // 
            // btnUsuCadastro
            // 
            this.btnUsuCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUsuCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuCadastro.FlatAppearance.BorderSize = 0;
            this.btnUsuCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnUsuCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnUsuCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuCadastro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuCadastro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnUsuCadastro.Name = "btnUsuCadastro";
            this.btnUsuCadastro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuCadastro.Size = new System.Drawing.Size(233, 25);
            this.btnUsuCadastro.TabIndex = 2;
            this.btnUsuCadastro.Text = "Cadastro de Usuário";
            this.btnUsuCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuCadastro.UseVisualStyleBackColor = false;
            // 
            // btnMenuUsuario
            // 
            this.btnMenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuUsuario.FlatAppearance.BorderSize = 0;
            this.btnMenuUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnMenuUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnMenuUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuUsuario.Location = new System.Drawing.Point(0, 485);
            this.btnMenuUsuario.Name = "btnMenuUsuario";
            this.btnMenuUsuario.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuUsuario.Size = new System.Drawing.Size(233, 40);
            this.btnMenuUsuario.TabIndex = 9;
            this.btnMenuUsuario.Text = "Usuário";
            this.btnMenuUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUsuario.UseVisualStyleBackColor = false;
            this.btnMenuUsuario.Click += new System.EventHandler(this.btnMenuUsuario_Click);
            // 
            // pnlSubMenuFornecedor
            // 
            this.pnlSubMenuFornecedor.AutoSize = true;
            this.pnlSubMenuFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlSubMenuFornecedor.Controls.Add(this.bntForRelatorio);
            this.pnlSubMenuFornecedor.Controls.Add(this.btnForCadastro);
            this.pnlSubMenuFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuFornecedor.Location = new System.Drawing.Point(0, 435);
            this.pnlSubMenuFornecedor.Name = "pnlSubMenuFornecedor";
            this.pnlSubMenuFornecedor.Size = new System.Drawing.Size(233, 50);
            this.pnlSubMenuFornecedor.TabIndex = 8;
            // 
            // bntForRelatorio
            // 
            this.bntForRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bntForRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntForRelatorio.FlatAppearance.BorderSize = 0;
            this.bntForRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.bntForRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.bntForRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntForRelatorio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntForRelatorio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntForRelatorio.Location = new System.Drawing.Point(0, 25);
            this.bntForRelatorio.Name = "bntForRelatorio";
            this.bntForRelatorio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bntForRelatorio.Size = new System.Drawing.Size(233, 25);
            this.bntForRelatorio.TabIndex = 4;
            this.bntForRelatorio.Text = "Relatório de Fornecedores";
            this.bntForRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntForRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnForCadastro
            // 
            this.btnForCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnForCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForCadastro.FlatAppearance.BorderSize = 0;
            this.btnForCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnForCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnForCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForCadastro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnForCadastro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnForCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnForCadastro.Name = "btnForCadastro";
            this.btnForCadastro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnForCadastro.Size = new System.Drawing.Size(233, 25);
            this.btnForCadastro.TabIndex = 2;
            this.btnForCadastro.Text = "Cadastro de Fornecedor";
            this.btnForCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForCadastro.UseVisualStyleBackColor = false;
            // 
            // btnMenuFornecedor
            // 
            this.btnMenuFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuFornecedor.FlatAppearance.BorderSize = 0;
            this.btnMenuFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnMenuFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnMenuFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuFornecedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuFornecedor.Location = new System.Drawing.Point(0, 395);
            this.btnMenuFornecedor.Name = "btnMenuFornecedor";
            this.btnMenuFornecedor.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuFornecedor.Size = new System.Drawing.Size(233, 40);
            this.btnMenuFornecedor.TabIndex = 7;
            this.btnMenuFornecedor.Text = "Fornecedor";
            this.btnMenuFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFornecedor.UseVisualStyleBackColor = false;
            this.btnMenuFornecedor.Click += new System.EventHandler(this.btnMenuFornecedor_Click);
            // 
            // pnlSubMenuEstoque
            // 
            this.pnlSubMenuEstoque.AutoSize = true;
            this.pnlSubMenuEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlSubMenuEstoque.Controls.Add(this.btnSMEstControle);
            this.pnlSubMenuEstoque.Controls.Add(this.btnSMEstEntradaMerc);
            this.pnlSubMenuEstoque.Controls.Add(this.btnSMEstSubGrupo);
            this.pnlSubMenuEstoque.Controls.Add(this.btnSMEstGrupo);
            this.pnlSubMenuEstoque.Controls.Add(this.btnSMEstMarca);
            this.pnlSubMenuEstoque.Controls.Add(this.btnSMEstProduto);
            this.pnlSubMenuEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuEstoque.Location = new System.Drawing.Point(0, 245);
            this.pnlSubMenuEstoque.Name = "pnlSubMenuEstoque";
            this.pnlSubMenuEstoque.Size = new System.Drawing.Size(233, 150);
            this.pnlSubMenuEstoque.TabIndex = 6;
            // 
            // btnSMEstControle
            // 
            this.btnSMEstControle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSMEstControle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMEstControle.FlatAppearance.BorderSize = 0;
            this.btnSMEstControle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnSMEstControle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSMEstControle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMEstControle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSMEstControle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSMEstControle.Location = new System.Drawing.Point(0, 125);
            this.btnSMEstControle.Name = "btnSMEstControle";
            this.btnSMEstControle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSMEstControle.Size = new System.Drawing.Size(233, 25);
            this.btnSMEstControle.TabIndex = 9;
            this.btnSMEstControle.Text = "Controle de Estoque";
            this.btnSMEstControle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMEstControle.UseVisualStyleBackColor = false;
            // 
            // btnSMEstEntradaMerc
            // 
            this.btnSMEstEntradaMerc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSMEstEntradaMerc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMEstEntradaMerc.FlatAppearance.BorderSize = 0;
            this.btnSMEstEntradaMerc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnSMEstEntradaMerc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSMEstEntradaMerc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMEstEntradaMerc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSMEstEntradaMerc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSMEstEntradaMerc.Location = new System.Drawing.Point(0, 100);
            this.btnSMEstEntradaMerc.Name = "btnSMEstEntradaMerc";
            this.btnSMEstEntradaMerc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSMEstEntradaMerc.Size = new System.Drawing.Size(233, 25);
            this.btnSMEstEntradaMerc.TabIndex = 8;
            this.btnSMEstEntradaMerc.Text = "Entrada de Mercadorias";
            this.btnSMEstEntradaMerc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMEstEntradaMerc.UseVisualStyleBackColor = false;
            // 
            // btnSMEstSubGrupo
            // 
            this.btnSMEstSubGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSMEstSubGrupo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMEstSubGrupo.FlatAppearance.BorderSize = 0;
            this.btnSMEstSubGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnSMEstSubGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSMEstSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMEstSubGrupo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSMEstSubGrupo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSMEstSubGrupo.Location = new System.Drawing.Point(0, 75);
            this.btnSMEstSubGrupo.Name = "btnSMEstSubGrupo";
            this.btnSMEstSubGrupo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSMEstSubGrupo.Size = new System.Drawing.Size(233, 25);
            this.btnSMEstSubGrupo.TabIndex = 7;
            this.btnSMEstSubGrupo.Text = "Cadastro de Sub Grupos";
            this.btnSMEstSubGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMEstSubGrupo.UseVisualStyleBackColor = false;
            // 
            // btnSMEstGrupo
            // 
            this.btnSMEstGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSMEstGrupo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMEstGrupo.FlatAppearance.BorderSize = 0;
            this.btnSMEstGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnSMEstGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSMEstGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMEstGrupo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSMEstGrupo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSMEstGrupo.Location = new System.Drawing.Point(0, 50);
            this.btnSMEstGrupo.Name = "btnSMEstGrupo";
            this.btnSMEstGrupo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSMEstGrupo.Size = new System.Drawing.Size(233, 25);
            this.btnSMEstGrupo.TabIndex = 6;
            this.btnSMEstGrupo.Text = "Cadastro de Grupos";
            this.btnSMEstGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMEstGrupo.UseVisualStyleBackColor = false;
            // 
            // btnSMEstMarca
            // 
            this.btnSMEstMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSMEstMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMEstMarca.FlatAppearance.BorderSize = 0;
            this.btnSMEstMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnSMEstMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSMEstMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMEstMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSMEstMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSMEstMarca.Location = new System.Drawing.Point(0, 25);
            this.btnSMEstMarca.Name = "btnSMEstMarca";
            this.btnSMEstMarca.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSMEstMarca.Size = new System.Drawing.Size(233, 25);
            this.btnSMEstMarca.TabIndex = 5;
            this.btnSMEstMarca.Text = "Cadastro de Marcas";
            this.btnSMEstMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMEstMarca.UseVisualStyleBackColor = false;
            // 
            // btnSMEstProduto
            // 
            this.btnSMEstProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSMEstProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMEstProduto.FlatAppearance.BorderSize = 0;
            this.btnSMEstProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnSMEstProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSMEstProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMEstProduto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSMEstProduto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSMEstProduto.Location = new System.Drawing.Point(0, 0);
            this.btnSMEstProduto.Name = "btnSMEstProduto";
            this.btnSMEstProduto.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSMEstProduto.Size = new System.Drawing.Size(233, 25);
            this.btnSMEstProduto.TabIndex = 2;
            this.btnSMEstProduto.Text = "Cadastro de Produtos";
            this.btnSMEstProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMEstProduto.UseVisualStyleBackColor = false;
            // 
            // btnMenuEstoque
            // 
            this.btnMenuEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuEstoque.FlatAppearance.BorderSize = 0;
            this.btnMenuEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnMenuEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnMenuEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEstoque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuEstoque.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuEstoque.Location = new System.Drawing.Point(0, 205);
            this.btnMenuEstoque.Name = "btnMenuEstoque";
            this.btnMenuEstoque.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuEstoque.Size = new System.Drawing.Size(233, 40);
            this.btnMenuEstoque.TabIndex = 5;
            this.btnMenuEstoque.Text = "Estoque";
            this.btnMenuEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEstoque.UseVisualStyleBackColor = false;
            this.btnMenuEstoque.Click += new System.EventHandler(this.btnMenuEstoque_Click);
            // 
            // pnlSubMenuVenda
            // 
            this.pnlSubMenuVenda.AutoSize = true;
            this.pnlSubMenuVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlSubMenuVenda.Controls.Add(this.btnSMVenRelatorio);
            this.pnlSubMenuVenda.Controls.Add(this.btnSMVenRegistro);
            this.pnlSubMenuVenda.Controls.Add(this.btnSMVenPedido);
            this.pnlSubMenuVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuVenda.Location = new System.Drawing.Point(0, 130);
            this.pnlSubMenuVenda.Name = "pnlSubMenuVenda";
            this.pnlSubMenuVenda.Size = new System.Drawing.Size(233, 75);
            this.pnlSubMenuVenda.TabIndex = 4;
            // 
            // btnSMVenRelatorio
            // 
            this.btnSMVenRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSMVenRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMVenRelatorio.FlatAppearance.BorderSize = 0;
            this.btnSMVenRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnSMVenRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSMVenRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMVenRelatorio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSMVenRelatorio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSMVenRelatorio.Location = new System.Drawing.Point(0, 50);
            this.btnSMVenRelatorio.Name = "btnSMVenRelatorio";
            this.btnSMVenRelatorio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSMVenRelatorio.Size = new System.Drawing.Size(233, 25);
            this.btnSMVenRelatorio.TabIndex = 3;
            this.btnSMVenRelatorio.Text = "Relatórios de Vendas";
            this.btnSMVenRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMVenRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnSMVenRegistro
            // 
            this.btnSMVenRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSMVenRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMVenRegistro.FlatAppearance.BorderSize = 0;
            this.btnSMVenRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnSMVenRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSMVenRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMVenRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSMVenRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSMVenRegistro.Location = new System.Drawing.Point(0, 25);
            this.btnSMVenRegistro.Name = "btnSMVenRegistro";
            this.btnSMVenRegistro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSMVenRegistro.Size = new System.Drawing.Size(233, 25);
            this.btnSMVenRegistro.TabIndex = 4;
            this.btnSMVenRegistro.Text = "Registrar Venda";
            this.btnSMVenRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMVenRegistro.UseVisualStyleBackColor = false;
            // 
            // btnSMVenPedido
            // 
            this.btnSMVenPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSMVenPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMVenPedido.FlatAppearance.BorderSize = 0;
            this.btnSMVenPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnSMVenPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSMVenPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMVenPedido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSMVenPedido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSMVenPedido.Location = new System.Drawing.Point(0, 0);
            this.btnSMVenPedido.Name = "btnSMVenPedido";
            this.btnSMVenPedido.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSMVenPedido.Size = new System.Drawing.Size(233, 25);
            this.btnSMVenPedido.TabIndex = 2;
            this.btnSMVenPedido.Text = "Pedido de Venda";
            this.btnSMVenPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMVenPedido.UseVisualStyleBackColor = false;
            // 
            // btnMenuVenda
            // 
            this.btnMenuVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuVenda.FlatAppearance.BorderSize = 0;
            this.btnMenuVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnMenuVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnMenuVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuVenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuVenda.Location = new System.Drawing.Point(0, 90);
            this.btnMenuVenda.Name = "btnMenuVenda";
            this.btnMenuVenda.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuVenda.Size = new System.Drawing.Size(233, 40);
            this.btnMenuVenda.TabIndex = 3;
            this.btnMenuVenda.Text = "Venda";
            this.btnMenuVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuVenda.UseVisualStyleBackColor = false;
            this.btnMenuVenda.Click += new System.EventHandler(this.btnMenuVenda_Click);
            // 
            // pnlSubMenuCliente
            // 
            this.pnlSubMenuCliente.AutoSize = true;
            this.pnlSubMenuCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlSubMenuCliente.Controls.Add(this.btnSMCliRelatorio);
            this.pnlSubMenuCliente.Controls.Add(this.btnSMCliCadastro);
            this.pnlSubMenuCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuCliente.Location = new System.Drawing.Point(0, 40);
            this.pnlSubMenuCliente.Name = "pnlSubMenuCliente";
            this.pnlSubMenuCliente.Size = new System.Drawing.Size(233, 50);
            this.pnlSubMenuCliente.TabIndex = 2;
            // 
            // btnSMCliRelatorio
            // 
            this.btnSMCliRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSMCliRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMCliRelatorio.FlatAppearance.BorderSize = 0;
            this.btnSMCliRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnSMCliRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSMCliRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMCliRelatorio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSMCliRelatorio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSMCliRelatorio.Location = new System.Drawing.Point(0, 25);
            this.btnSMCliRelatorio.Name = "btnSMCliRelatorio";
            this.btnSMCliRelatorio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSMCliRelatorio.Size = new System.Drawing.Size(233, 25);
            this.btnSMCliRelatorio.TabIndex = 3;
            this.btnSMCliRelatorio.Text = "Relatórios de Clientes";
            this.btnSMCliRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCliRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnSMCliCadastro
            // 
            this.btnSMCliCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSMCliCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMCliCadastro.FlatAppearance.BorderSize = 0;
            this.btnSMCliCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnSMCliCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSMCliCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMCliCadastro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSMCliCadastro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSMCliCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnSMCliCadastro.Name = "btnSMCliCadastro";
            this.btnSMCliCadastro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSMCliCadastro.Size = new System.Drawing.Size(233, 25);
            this.btnSMCliCadastro.TabIndex = 2;
            this.btnSMCliCadastro.Text = "Cadastro de Cliente";
            this.btnSMCliCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCliCadastro.UseVisualStyleBackColor = false;
            // 
            // btnMenuCliente
            // 
            this.btnMenuCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMenuCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuCliente.FlatAppearance.BorderSize = 0;
            this.btnMenuCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnMenuCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnMenuCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuCliente.ForeColor = System.Drawing.Color.LightGray;
            this.btnMenuCliente.Location = new System.Drawing.Point(0, 0);
            this.btnMenuCliente.Name = "btnMenuCliente";
            this.btnMenuCliente.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuCliente.Size = new System.Drawing.Size(233, 40);
            this.btnMenuCliente.TabIndex = 1;
            this.btnMenuCliente.Text = "Cliente";
            this.btnMenuCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCliente.UseVisualStyleBackColor = false;
            this.btnMenuCliente.Click += new System.EventHandler(this.btnMenuCliente_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Maroon;
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(255, 100);
            this.pnlLogo.TabIndex = 1;
            // 
            // FmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 659);
            this.Controls.Add(this.pnlRotinas);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FmrPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenus.ResumeLayout(false);
            this.pnlMenus.PerformLayout();
            this.pnlSubMenuUsuario.ResumeLayout(false);
            this.pnlSubMenuFornecedor.ResumeLayout(false);
            this.pnlSubMenuEstoque.ResumeLayout(false);
            this.pnlSubMenuVenda.ResumeLayout(false);
            this.pnlSubMenuCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlRotinas;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlMenus;
        private System.Windows.Forms.Panel pnlSubMenuFornecedor;
        private System.Windows.Forms.Button bntForRelatorio;
        private System.Windows.Forms.Button btnForCadastro;
        private System.Windows.Forms.Button btnMenuFornecedor;
        private System.Windows.Forms.Panel pnlSubMenuEstoque;
        private System.Windows.Forms.Button btnSMEstControle;
        private System.Windows.Forms.Button btnSMEstEntradaMerc;
        private System.Windows.Forms.Button btnSMEstSubGrupo;
        private System.Windows.Forms.Button btnSMEstGrupo;
        private System.Windows.Forms.Button btnSMEstMarca;
        private System.Windows.Forms.Button btnSMEstProduto;
        private System.Windows.Forms.Button btnMenuEstoque;
        private System.Windows.Forms.Panel pnlSubMenuVenda;
        private System.Windows.Forms.Button btnSMVenRelatorio;
        private System.Windows.Forms.Button btnSMVenRegistro;
        private System.Windows.Forms.Button btnSMVenPedido;
        private System.Windows.Forms.Button btnMenuVenda;
        private System.Windows.Forms.Panel pnlSubMenuCliente;
        private System.Windows.Forms.Button btnSMCliRelatorio;
        private System.Windows.Forms.Button btnSMCliCadastro;
        private System.Windows.Forms.Button btnMenuCliente;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlSubMenuUsuario;
        private System.Windows.Forms.Button btnUsuPermissoes;
        private System.Windows.Forms.Button btnUsuControleAcesso;
        private System.Windows.Forms.Button btnUsuCadastro;
        private System.Windows.Forms.Button btnMenuUsuario;
    }
}

