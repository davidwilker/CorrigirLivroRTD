
namespace CorrigirLivrosRTD
{
    partial class formConfigBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConfigBanco));
            this.editCaminhoBanco = new System.Windows.Forms.TextBox();
            this.editServidor = new System.Windows.Forms.TextBox();
            this.editPorta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisaBanco = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnTesteConexao = new System.Windows.Forms.Button();
            this.btnSalvarConexao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editCaminhoBanco
            // 
            this.editCaminhoBanco.Enabled = false;
            this.editCaminhoBanco.Location = new System.Drawing.Point(20, 34);
            this.editCaminhoBanco.Name = "editCaminhoBanco";
            this.editCaminhoBanco.ReadOnly = true;
            this.editCaminhoBanco.Size = new System.Drawing.Size(205, 20);
            this.editCaminhoBanco.TabIndex = 0;
            // 
            // editServidor
            // 
            this.editServidor.Location = new System.Drawing.Point(20, 73);
            this.editServidor.Name = "editServidor";
            this.editServidor.Size = new System.Drawing.Size(149, 20);
            this.editServidor.TabIndex = 2;
            // 
            // editPorta
            // 
            this.editPorta.Location = new System.Drawing.Point(175, 73);
            this.editPorta.Name = "editPorta";
            this.editPorta.Size = new System.Drawing.Size(86, 20);
            this.editPorta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Caminho do banco de dados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Servidor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Porta";
            // 
            // btnPesquisaBanco
            // 
            this.btnPesquisaBanco.Location = new System.Drawing.Point(237, 32);
            this.btnPesquisaBanco.Name = "btnPesquisaBanco";
            this.btnPesquisaBanco.Size = new System.Drawing.Size(24, 23);
            this.btnPesquisaBanco.TabIndex = 7;
            this.btnPesquisaBanco.Text = "...";
            this.btnPesquisaBanco.UseVisualStyleBackColor = true;
            this.btnPesquisaBanco.Click += new System.EventHandler(this.btnPesquisaBanco_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnTesteConexao
            // 
            this.btnTesteConexao.Location = new System.Drawing.Point(20, 137);
            this.btnTesteConexao.Name = "btnTesteConexao";
            this.btnTesteConexao.Size = new System.Drawing.Size(241, 23);
            this.btnTesteConexao.TabIndex = 8;
            this.btnTesteConexao.Text = "Testar Conexão";
            this.btnTesteConexao.UseVisualStyleBackColor = true;
            this.btnTesteConexao.Click += new System.EventHandler(this.btnTesteConexao_Click);
            // 
            // btnSalvarConexao
            // 
            this.btnSalvarConexao.Location = new System.Drawing.Point(20, 108);
            this.btnSalvarConexao.Name = "btnSalvarConexao";
            this.btnSalvarConexao.Size = new System.Drawing.Size(241, 23);
            this.btnSalvarConexao.TabIndex = 9;
            this.btnSalvarConexao.Text = "Salvar";
            this.btnSalvarConexao.UseVisualStyleBackColor = true;
            this.btnSalvarConexao.Click += new System.EventHandler(this.btnSalvarConexao_Click);
            // 
            // formConfigBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.btnSalvarConexao);
            this.Controls.Add(this.btnTesteConexao);
            this.Controls.Add(this.btnPesquisaBanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editPorta);
            this.Controls.Add(this.editServidor);
            this.Controls.Add(this.editCaminhoBanco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 223);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 223);
            this.Name = "formConfigBanco";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Banco de Dados";
            this.Load += new System.EventHandler(this.formConfigBanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editCaminhoBanco;
        private System.Windows.Forms.TextBox editServidor;
        private System.Windows.Forms.TextBox editPorta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisaBanco;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnTesteConexao;
        private System.Windows.Forms.Button btnSalvarConexao;
    }
}