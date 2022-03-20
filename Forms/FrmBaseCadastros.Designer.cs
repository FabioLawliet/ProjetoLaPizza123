
namespace LaPizza.Forms
{
    partial class FrmBaseCadastros
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
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlAcoes = new System.Windows.Forms.Panel();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnAcaoExcluir = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.bntAcaoConsultar = new System.Windows.Forms.Button();
            this.btnAcaoEditar = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.btnAcaoAdicionar = new System.Windows.Forms.Button();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.pnlFundo.SuspendLayout();
            this.pnlAcoes.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.Maroon;
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(1008, 50);
            this.pnlCabecalho.TabIndex = 0;
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.pnlFundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFundo.Controls.Add(this.pnlRodape);
            this.pnlFundo.Controls.Add(this.pnlAcoes);
            this.pnlFundo.Controls.Add(this.pnlCabecalho);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFundo.Location = new System.Drawing.Point(0, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(1008, 600);
            this.pnlFundo.TabIndex = 1;
            // 
            // pnlAcoes
            // 
            this.pnlAcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlAcoes.Controls.Add(this.btnAcaoAdicionar);
            this.pnlAcoes.Controls.Add(this.splitter5);
            this.pnlAcoes.Controls.Add(this.btnAcaoEditar);
            this.pnlAcoes.Controls.Add(this.splitter4);
            this.pnlAcoes.Controls.Add(this.bntAcaoConsultar);
            this.pnlAcoes.Controls.Add(this.splitter3);
            this.pnlAcoes.Controls.Add(this.btnAcaoExcluir);
            this.pnlAcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcoes.Location = new System.Drawing.Point(0, 50);
            this.pnlAcoes.Name = "pnlAcoes";
            this.pnlAcoes.Padding = new System.Windows.Forms.Padding(5);
            this.pnlAcoes.Size = new System.Drawing.Size(1008, 50);
            this.pnlAcoes.TabIndex = 0;
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlRodape.Controls.Add(this.btnConfirmar);
            this.pnlRodape.Controls.Add(this.splitter2);
            this.pnlRodape.Controls.Add(this.btnCancelar);
            this.pnlRodape.Controls.Add(this.splitter1);
            this.pnlRodape.Controls.Add(this.btnSair);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 550);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Padding = new System.Windows.Forms.Padding(5);
            this.pnlRodape.Size = new System.Drawing.Size(1008, 50);
            this.pnlRodape.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Brown;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(883, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 40);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(878, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 40);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(758, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.Location = new System.Drawing.Point(633, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(120, 40);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(753, 5);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 40);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // btnAcaoExcluir
            // 
            this.btnAcaoExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAcaoExcluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAcaoExcluir.FlatAppearance.BorderSize = 0;
            this.btnAcaoExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcaoExcluir.ForeColor = System.Drawing.Color.Transparent;
            this.btnAcaoExcluir.Image = global::LaPizza.Properties.Resources.AcaoExcluir;
            this.btnAcaoExcluir.Location = new System.Drawing.Point(963, 5);
            this.btnAcaoExcluir.Name = "btnAcaoExcluir";
            this.btnAcaoExcluir.Size = new System.Drawing.Size(40, 40);
            this.btnAcaoExcluir.TabIndex = 2;
            this.btnAcaoExcluir.UseVisualStyleBackColor = true;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Location = new System.Drawing.Point(958, 5);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 40);
            this.splitter3.TabIndex = 4;
            this.splitter3.TabStop = false;
            // 
            // bntAcaoConsultar
            // 
            this.bntAcaoConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntAcaoConsultar.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntAcaoConsultar.FlatAppearance.BorderSize = 0;
            this.bntAcaoConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAcaoConsultar.ForeColor = System.Drawing.Color.Transparent;
            this.bntAcaoConsultar.Image = global::LaPizza.Properties.Resources.AcaoConsultar;
            this.bntAcaoConsultar.Location = new System.Drawing.Point(918, 5);
            this.bntAcaoConsultar.Name = "bntAcaoConsultar";
            this.bntAcaoConsultar.Size = new System.Drawing.Size(40, 40);
            this.bntAcaoConsultar.TabIndex = 5;
            this.bntAcaoConsultar.UseVisualStyleBackColor = true;
            // 
            // btnAcaoEditar
            // 
            this.btnAcaoEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAcaoEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAcaoEditar.FlatAppearance.BorderSize = 0;
            this.btnAcaoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcaoEditar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAcaoEditar.Image = global::LaPizza.Properties.Resources.AcaoEditar;
            this.btnAcaoEditar.Location = new System.Drawing.Point(873, 5);
            this.btnAcaoEditar.Name = "btnAcaoEditar";
            this.btnAcaoEditar.Size = new System.Drawing.Size(40, 40);
            this.btnAcaoEditar.TabIndex = 7;
            this.btnAcaoEditar.UseVisualStyleBackColor = true;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter4.Location = new System.Drawing.Point(913, 5);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(5, 40);
            this.splitter4.TabIndex = 6;
            this.splitter4.TabStop = false;
            // 
            // btnAcaoAdicionar
            // 
            this.btnAcaoAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcaoAdicionar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAcaoAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAcaoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcaoAdicionar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAcaoAdicionar.Image = global::LaPizza.Properties.Resources.AcaoAdicionar;
            this.btnAcaoAdicionar.Location = new System.Drawing.Point(828, 5);
            this.btnAcaoAdicionar.Name = "btnAcaoAdicionar";
            this.btnAcaoAdicionar.Size = new System.Drawing.Size(40, 40);
            this.btnAcaoAdicionar.TabIndex = 9;
            this.btnAcaoAdicionar.UseVisualStyleBackColor = false;
            // 
            // splitter5
            // 
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter5.Location = new System.Drawing.Point(868, 5);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(5, 40);
            this.splitter5.TabIndex = 8;
            this.splitter5.TabStop = false;
            // 
            // FrmBaseCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 600);
            this.Controls.Add(this.pnlFundo);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Name = "FrmBaseCadastros";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario Base";
            this.pnlFundo.ResumeLayout(false);
            this.pnlAcoes.ResumeLayout(false);
            this.pnlRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel pnlAcoes;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnAcaoExcluir;
        private System.Windows.Forms.Button btnAcaoAdicionar;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Button btnAcaoEditar;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button bntAcaoConsultar;
    }
}