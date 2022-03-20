
namespace LaPizza.Forms
{
    partial class FmrCadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMenuAdicionar = new System.Windows.Forms.Button();
            this.bntMenuExcluir = new System.Windows.Forms.Button();
            this.btnMenuConsultar = new System.Windows.Forms.Button();
            this.btnMenuEditar = new System.Windows.Forms.Button();
            this.pnlCabecalho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCabecalho.Controls.Add(this.label1);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(908, 42);
            this.pnlCabecalho.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, -90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 637);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 586);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 51);
            this.panel1.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Brown;
            this.btnSair.Enabled = false;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(822, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 39);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(736, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 39);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(650, 6);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(80, 39);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 42);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMenu.Size = new System.Drawing.Size(908, 52);
            this.pnlMenu.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnMenuAdicionar);
            this.panel3.Controls.Add(this.bntMenuExcluir);
            this.panel3.Controls.Add(this.btnMenuConsultar);
            this.panel3.Controls.Add(this.btnMenuEditar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(709, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 42);
            this.panel3.TabIndex = 0;
            // 
            // btnMenuAdicionar
            // 
            this.btnMenuAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuAdicionar.BackgroundImage = global::LaPizza.Properties.Resources.CadastroAdicionar40x40;
            this.btnMenuAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuAdicionar.FlatAppearance.BorderSize = 0;
            this.btnMenuAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAdicionar.Location = new System.Drawing.Point(1, 0);
            this.btnMenuAdicionar.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnMenuAdicionar.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnMenuAdicionar.Name = "btnMenuAdicionar";
            this.btnMenuAdicionar.Size = new System.Drawing.Size(40, 40);
            this.btnMenuAdicionar.TabIndex = 4;
            this.btnMenuAdicionar.UseVisualStyleBackColor = false;
            // 
            // bntMenuExcluir
            // 
            this.bntMenuExcluir.BackColor = System.Drawing.Color.Transparent;
            this.bntMenuExcluir.BackgroundImage = global::LaPizza.Properties.Resources.CadastroExcluir40x40;
            this.bntMenuExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntMenuExcluir.FlatAppearance.BorderSize = 0;
            this.bntMenuExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMenuExcluir.Location = new System.Drawing.Point(151, 0);
            this.bntMenuExcluir.Margin = new System.Windows.Forms.Padding(30);
            this.bntMenuExcluir.MaximumSize = new System.Drawing.Size(40, 40);
            this.bntMenuExcluir.MinimumSize = new System.Drawing.Size(40, 40);
            this.bntMenuExcluir.Name = "bntMenuExcluir";
            this.bntMenuExcluir.Padding = new System.Windows.Forms.Padding(30);
            this.bntMenuExcluir.Size = new System.Drawing.Size(40, 40);
            this.bntMenuExcluir.TabIndex = 1;
            this.bntMenuExcluir.UseVisualStyleBackColor = false;
            // 
            // btnMenuConsultar
            // 
            this.btnMenuConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuConsultar.BackgroundImage = global::LaPizza.Properties.Resources.CadastroConsultar40x40;
            this.btnMenuConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuConsultar.Location = new System.Drawing.Point(101, 0);
            this.btnMenuConsultar.Margin = new System.Windows.Forms.Padding(30);
            this.btnMenuConsultar.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnMenuConsultar.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnMenuConsultar.Name = "btnMenuConsultar";
            this.btnMenuConsultar.Padding = new System.Windows.Forms.Padding(30);
            this.btnMenuConsultar.Size = new System.Drawing.Size(40, 40);
            this.btnMenuConsultar.TabIndex = 2;
            this.btnMenuConsultar.UseVisualStyleBackColor = false;
            // 
            // btnMenuEditar
            // 
            this.btnMenuEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuEditar.BackgroundImage = global::LaPizza.Properties.Resources.CadastroEditar40x40;
            this.btnMenuEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEditar.Location = new System.Drawing.Point(51, 0);
            this.btnMenuEditar.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnMenuEditar.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnMenuEditar.Name = "btnMenuEditar";
            this.btnMenuEditar.Size = new System.Drawing.Size(40, 40);
            this.btnMenuEditar.TabIndex = 3;
            this.btnMenuEditar.UseVisualStyleBackColor = false;
            // 
            // FmrCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Name = "FmrCadastroCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button bntMenuExcluir;
        private System.Windows.Forms.Button btnMenuAdicionar;
        private System.Windows.Forms.Button btnMenuEditar;
        private System.Windows.Forms.Button btnMenuConsultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCancelra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}