
namespace CorrigirLivrosRTD
{
    partial class formCorrigeRtd
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCorrigeRtd));
            this.cbxFrenteVerso = new System.Windows.Forms.CheckBox();
            this.editProtocoloInicial = new System.Windows.Forms.TextBox();
            this.editNroLivro = new System.Windows.Forms.TextBox();
            this.editProtocoloFinal = new System.Windows.Forms.TextBox();
            this.editNroPaginaInicialLivro = new System.Windows.Forms.TextBox();
            this.editQtdPaginasLivro = new System.Windows.Forms.TextBox();
            this.cbxLivroAB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscaDados = new System.Windows.Forms.Button();
            this.btnCorrigir = new System.Windows.Forms.Button();
            this.cbxPassaLimiteFolha = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgResultado = new System.Windows.Forms.DataGridView();
            this.cbxInsereLivros = new System.Windows.Forms.CheckBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxFrenteVerso
            // 
            this.cbxFrenteVerso.AutoSize = true;
            this.cbxFrenteVerso.Location = new System.Drawing.Point(268, 78);
            this.cbxFrenteVerso.Name = "cbxFrenteVerso";
            this.cbxFrenteVerso.Size = new System.Drawing.Size(117, 17);
            this.cbxFrenteVerso.TabIndex = 0;
            this.cbxFrenteVerso.Text = "Usa Frente e Verso";
            this.cbxFrenteVerso.UseVisualStyleBackColor = true;
            this.cbxFrenteVerso.MouseHover += new System.EventHandler(this.cbxFrenteVerso_MouseHover);
            // 
            // editProtocoloInicial
            // 
            this.editProtocoloInicial.Location = new System.Drawing.Point(18, 52);
            this.editProtocoloInicial.Name = "editProtocoloInicial";
            this.editProtocoloInicial.Size = new System.Drawing.Size(100, 20);
            this.editProtocoloInicial.TabIndex = 1;
            // 
            // editNroLivro
            // 
            this.editNroLivro.Location = new System.Drawing.Point(143, 52);
            this.editNroLivro.Name = "editNroLivro";
            this.editNroLivro.Size = new System.Drawing.Size(100, 20);
            this.editNroLivro.TabIndex = 2;
            this.editNroLivro.Text = "1";
            // 
            // editProtocoloFinal
            // 
            this.editProtocoloFinal.Location = new System.Drawing.Point(18, 111);
            this.editProtocoloFinal.Name = "editProtocoloFinal";
            this.editProtocoloFinal.Size = new System.Drawing.Size(100, 20);
            this.editProtocoloFinal.TabIndex = 3;
            // 
            // editNroPaginaInicialLivro
            // 
            this.editNroPaginaInicialLivro.Location = new System.Drawing.Point(143, 111);
            this.editNroPaginaInicialLivro.Name = "editNroPaginaInicialLivro";
            this.editNroPaginaInicialLivro.Size = new System.Drawing.Size(100, 20);
            this.editNroPaginaInicialLivro.TabIndex = 4;
            this.editNroPaginaInicialLivro.Text = "1";
            // 
            // editQtdPaginasLivro
            // 
            this.editQtdPaginasLivro.Location = new System.Drawing.Point(268, 52);
            this.editQtdPaginasLivro.Name = "editQtdPaginasLivro";
            this.editQtdPaginasLivro.Size = new System.Drawing.Size(154, 20);
            this.editQtdPaginasLivro.TabIndex = 5;
            this.editQtdPaginasLivro.Text = "200";
            // 
            // cbxLivroAB
            // 
            this.cbxLivroAB.AllowDrop = true;
            this.cbxLivroAB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLivroAB.FormattingEnabled = true;
            this.cbxLivroAB.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbxLivroAB.Location = new System.Drawing.Point(385, 103);
            this.cbxLivroAB.Name = "cbxLivroAB";
            this.cbxLivroAB.Size = new System.Drawing.Size(37, 21);
            this.cbxLivroAB.TabIndex = 6;
            this.cbxLivroAB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Protocolo Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nº Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nº de Páginas por Livro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Protocolo Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Página inicio";
            // 
            // btnBuscaDados
            // 
            this.btnBuscaDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaDados.Location = new System.Drawing.Point(494, 43);
            this.btnBuscaDados.Name = "btnBuscaDados";
            this.btnBuscaDados.Size = new System.Drawing.Size(93, 45);
            this.btnBuscaDados.TabIndex = 12;
            this.btnBuscaDados.Text = "Buscar Dados";
            this.btnBuscaDados.UseVisualStyleBackColor = true;
            this.btnBuscaDados.Click += new System.EventHandler(this.btnBuscaDados_Click);
            this.btnBuscaDados.MouseHover += new System.EventHandler(this.btnBuscaDados_MouseHover);
            // 
            // btnCorrigir
            // 
            this.btnCorrigir.Enabled = false;
            this.btnCorrigir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrigir.Location = new System.Drawing.Point(454, 94);
            this.btnCorrigir.Name = "btnCorrigir";
            this.btnCorrigir.Size = new System.Drawing.Size(133, 36);
            this.btnCorrigir.TabIndex = 13;
            this.btnCorrigir.Text = "Corrigir";
            this.btnCorrigir.UseVisualStyleBackColor = true;
            this.btnCorrigir.Click += new System.EventHandler(this.btnCorrigir_Click);
            this.btnCorrigir.MouseHover += new System.EventHandler(this.btnCorrigir_MouseHover);
            // 
            // cbxPassaLimiteFolha
            // 
            this.cbxPassaLimiteFolha.AutoSize = true;
            this.cbxPassaLimiteFolha.Location = new System.Drawing.Point(268, 95);
            this.cbxPassaLimiteFolha.Name = "cbxPassaLimiteFolha";
            this.cbxPassaLimiteFolha.Size = new System.Drawing.Size(111, 17);
            this.cbxPassaLimiteFolha.TabIndex = 14;
            this.cbxPassaLimiteFolha.Text = "Passa Limite Livro";
            this.cbxPassaLimiteFolha.UseVisualStyleBackColor = true;
            this.cbxPassaLimiteFolha.MouseHover += new System.EventHandler(this.cbxPassaLimiteFolha_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // dtgResultado
            // 
            this.dtgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultado.Location = new System.Drawing.Point(12, 156);
            this.dtgResultado.Name = "dtgResultado";
            this.dtgResultado.ReadOnly = true;
            this.dtgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgResultado.Size = new System.Drawing.Size(580, 375);
            this.dtgResultado.TabIndex = 16;
            // 
            // cbxInsereLivros
            // 
            this.cbxInsereLivros.AutoSize = true;
            this.cbxInsereLivros.Location = new System.Drawing.Point(268, 113);
            this.cbxInsereLivros.Name = "cbxInsereLivros";
            this.cbxInsereLivros.Size = new System.Drawing.Size(85, 17);
            this.cbxInsereLivros.TabIndex = 17;
            this.cbxInsereLivros.Text = "Inserir Livros";
            this.cbxInsereLivros.UseVisualStyleBackColor = true;
            this.cbxInsereLivros.CheckedChanged += new System.EventHandler(this.cbxInsereLivros_CheckedChanged);
            this.cbxInsereLivros.MouseHover += new System.EventHandler(this.cbxInsereLivros_MouseHover);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Enabled = false;
            this.btnVoltar.Image = global::CorrigirLivrosRTD.Properties.Resources.voltar__2_;
            this.btnVoltar.Location = new System.Drawing.Point(454, 43);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(34, 45);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.MouseHover += new System.EventHandler(this.btnVoltar_MouseHover);
            // 
            // formCorrigeRtd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 543);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cbxInsereLivros);
            this.Controls.Add(this.dtgResultado);
            this.Controls.Add(this.cbxPassaLimiteFolha);
            this.Controls.Add(this.btnCorrigir);
            this.Controls.Add(this.btnBuscaDados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxLivroAB);
            this.Controls.Add(this.editQtdPaginasLivro);
            this.Controls.Add(this.editNroPaginaInicialLivro);
            this.Controls.Add(this.editProtocoloFinal);
            this.Controls.Add(this.editNroLivro);
            this.Controls.Add(this.editProtocoloInicial);
            this.Controls.Add(this.cbxFrenteVerso);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 582);
            this.MinimumSize = new System.Drawing.Size(620, 582);
            this.Name = "formCorrigeRtd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corrige Livros RTD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxFrenteVerso;
        private System.Windows.Forms.TextBox editProtocoloInicial;
        private System.Windows.Forms.TextBox editNroLivro;
        private System.Windows.Forms.TextBox editProtocoloFinal;
        private System.Windows.Forms.TextBox editNroPaginaInicialLivro;
        private System.Windows.Forms.TextBox editQtdPaginasLivro;
        private System.Windows.Forms.ComboBox cbxLivroAB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscaDados;
        private System.Windows.Forms.Button btnCorrigir;
        private System.Windows.Forms.CheckBox cbxPassaLimiteFolha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgResultado;
        private System.Windows.Forms.CheckBox cbxInsereLivros;
        private System.Windows.Forms.Button btnVoltar;
    }
}

