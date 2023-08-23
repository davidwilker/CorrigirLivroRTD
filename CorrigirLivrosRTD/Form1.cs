using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrigirLivrosRTD
{
    public partial class formCorrigeRtd : Form
    {
        DataTable dataTable;

        public formCorrigeRtd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxLivroAB.SelectedItem = "B";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConfigBanco form = new formConfigBanco();
            form.ShowDialog();
        }

        private void btnBuscaDados_Click(object sender, EventArgs e)
        {           

            if(editProtocoloFinal.Text != "" && editProtocoloInicial.Text != "")
            {

                BloquearCampos();

                string query = "select FIRST 100000 d.numero_protocolo, d.numero_registro, d.data_registro, d.numero_livro, d.letra_livro, "
               + " d.folha_inicial, d.lado_inicial, d.folha_final, d.lado_final, d.numero_paginas"
               + " from documentos d where d.documento_antigo <> 'S' "
               + " and d.numero_protocolo >=" + editProtocoloInicial.Text
               + " and d.numero_protocolo <=" + editProtocoloFinal.Text
               + " and d.letra_livro = '" + cbxLivroAB.SelectedItem + "'"
               + " order by d.numero_protocolo";

                //gera Tabela para trabalho
                dataTable = GetData(query);                

                //Envia o resultado para o DataGridView
                dtgResultado.DataSource = dataTable;

                CorrigeDataTable(dataTable, int.Parse(editNroLivro.Text), 
                                 int.Parse(editNroPaginaInicialLivro.Text), 
                                 int.Parse(editQtdPaginasLivro.Text), 
                                 cbxPassaLimiteFolha.Checked, 
                                 cbxFrenteVerso.Checked);
            } 
            else
            {
                MessageBox.Show("Preencha o Protocolo Inicial e Final para prosseguir!");
            }

        }

        static DataTable GetData(string query)
        {
            DataTable dataTable = new DataTable();
            using (FbConnection con = Conexao.PegarInstancia().PegarConexao())
                {
                con.Open();

                using (FbCommand command = new FbCommand(query, con))
                {
                    FbDataReader reader = command.ExecuteReader();
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }

        static DataTable CorrigeDataTable(DataTable dataTable, int numeroLivroAtual, int numeroPagAtual, int qtdPaginasLivro, bool passaLimite, bool frenteVerso)
        {

            int i = 0;
            string lado = "F";

            foreach (DataRow row in dataTable.Rows)
            {
                if (!frenteVerso)
                {
                    if (numeroPagAtual + int.Parse(dataTable.Rows[i]["numero_paginas"].ToString()) >= qtdPaginasLivro && !passaLimite)
                    {
                        numeroPagAtual = 1;
                        numeroLivroAtual++;
                    }
                    else if (numeroPagAtual > qtdPaginasLivro)
                    {
                        numeroPagAtual = 1;
                        numeroLivroAtual++;
                    }

                    dataTable.Rows[i]["numero_livro"] = numeroLivroAtual;

                    dataTable.Rows[i]["folha_inicial"] = numeroPagAtual;

                    dataTable.Rows[i]["folha_final"] = int.Parse(dataTable.Rows[i]["folha_inicial"].ToString()) + int.Parse(dataTable.Rows[i]["numero_paginas"].ToString()) - 1;

                    numeroPagAtual = int.Parse(dataTable.Rows[i]["folha_final"].ToString()) + 1;

                    i++;
                }
                else
                {                                        

                    if (numeroPagAtual + int.Parse(dataTable.Rows[i]["numero_paginas"].ToString()) >= qtdPaginasLivro && !passaLimite)
                    {
                        numeroPagAtual = 1;
                        lado = "F";
                        numeroLivroAtual++;
                    } 
                    else if (numeroPagAtual > qtdPaginasLivro)
                    {
                        numeroPagAtual = 1;
                        lado = "F";
                        numeroLivroAtual++;
                    }


                    dataTable.Rows[i]["numero_livro"] = numeroLivroAtual;
                    dataTable.Rows[i]["folha_inicial"] = numeroPagAtual;
                    dataTable.Rows[i]["lado_inicial"] = lado;

                    int pagInicial = numeroPagAtual;
                    int qtdPaginas = int.Parse(dataTable.Rows[i]["numero_paginas"].ToString());

                    for(int j = 1; j < qtdPaginas; j++)
                    {
                        if(lado == "V")
                        {
                            numeroPagAtual++;
                            lado = "F";
                        }
                        else
                        {
                            lado = "V";
                        }
                    }


                    dataTable.Rows[i]["folha_final"] = numeroPagAtual;
                    dataTable.Rows[i]["lado_final"] = lado;

                    if (lado == "V")
                    {
                        numeroPagAtual++;
                        lado = "F";
                    }
                    else
                    {
                        lado = "V";
                    }

                    i++;
                }

            }

            return dataTable;
        }

        private void GravarLinhasDataTable(DataTable dataTable)
        {
            StringBuilder cont = new StringBuilder();

            int i = 0;
            string fV = (!cbxFrenteVerso.Checked) ? "'N'" : "'S'";

            foreach (DataRow row in dataTable.Rows)
            {

                if (cbxInsereLivros.Checked && i>1)
                {
                    if(int.Parse(dataTable.Rows[i]["numero_livro"].ToString()) > int.Parse(dataTable.Rows[i - 1]["numero_livro"].ToString()))
                    {                        

                        cont.Append("INSERT INTO LIVROS(CHAVE_LIVROS, LETRA_LIVRO, NUMERO_LIVRO, FOLHA_INICIAL, FOLHA_FINAL, QTDE_FOLHAS, DT_ABERTURA, DT_FECHAMENTO, FRENTE_VERSO, ULTIMO_LADO_FOLHA, PULAR_VERSO_TERMINAR_FRENTE, CHAVE_NATUREZA)"
                                    + " VALUES((select COALESCE(MAX(chave_livros) + " + int.Parse(dataTable.Rows[i]["numero_livro"].ToString()) + ", 0+1) FROM LIVROS)"
                                    + ", '"+ cbxLivroAB.SelectedItem + "'"
                                    + ", "+ int.Parse(dataTable.Rows[i]["numero_livro"].ToString())
                                    + ", 1"
                                    + ", " + int.Parse(editQtdPaginasLivro.Text)
                                    + ", " + int.Parse(editQtdPaginasLivro.Text)
                                    + ", '" + dataTable.Rows[i]["data_registro"].ToString().Replace("/", ".")
                                    + "', '" + dataTable.Rows[i]["data_registro"].ToString().Replace("/", ".")
                                    + "', " + fV
                                    + ", NULL, NULL, NULL);");
                        cont.AppendLine();
                    }                    
                }else if (i==0 && cbxInsereLivros.Checked)
                {
                    cont.Append("INSERT INTO LIVROS(CHAVE_LIVROS, LETRA_LIVRO, NUMERO_LIVRO, FOLHA_INICIAL, FOLHA_FINAL, QTDE_FOLHAS, DT_ABERTURA, DT_FECHAMENTO, FRENTE_VERSO, ULTIMO_LADO_FOLHA, PULAR_VERSO_TERMINAR_FRENTE, CHAVE_NATUREZA)"
                                    + " VALUES((select COALESCE(MAX(chave_livros) + "+ int.Parse(dataTable.Rows[i]["numero_livro"].ToString())+", 0+1) FROM LIVROS)"
                                    + ", '" + cbxLivroAB.SelectedItem + "'"
                                    + ", " + int.Parse(dataTable.Rows[i]["numero_livro"].ToString())
                                    + ", 1"
                                    + ", " + int.Parse(editQtdPaginasLivro.Text)
                                    + ", " + int.Parse(editQtdPaginasLivro.Text)
                                    + ", '" + dataTable.Rows[i]["data_registro"].ToString().Replace("/", ".")
                                    + "', '"+ dataTable.Rows[i]["data_registro"].ToString().Replace("/", ".")
                                    + "', "+ fV
                                    + ", NULL, NULL, NULL);");
                    cont.AppendLine();
                }

                cont.Append("update documentos set numero_livro = "+int.Parse(dataTable.Rows[i]["numero_livro"].ToString())
                                                 + ", folha_inicial = "+ int.Parse(dataTable.Rows[i]["folha_inicial"].ToString())
                                                 + ", lado_inicial = '"+ dataTable.Rows[i]["lado_inicial"].ToString()+"'"
                                                 + ", folha_final = "+ int.Parse(dataTable.Rows[i]["folha_final"].ToString())
                                                 + ", lado_final = '" + dataTable.Rows[i]["lado_final"].ToString()+"'"
                                                 + " where numero_protocolo = "+ int.Parse(dataTable.Rows[i]["numero_protocolo"].ToString())
                                                 + " and letra_livro = '" + cbxLivroAB.SelectedItem + "';");
                cont.AppendLine();
                i++;
            }

            // Escrever o conteúdo no arquivo de texto
            string filePath = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "resultado.sql"; 
            File.WriteAllText(filePath, cont.ToString());         

        }

        private void UpdateBanco()
        {
            // Ler o arquivo resultado.sql
            string sqlScript = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "resultado.sql");

            using (FbConnection con = Conexao.PegarInstancia().PegarConexao())
            {
                try
                {
                    con.Open();
                    
                    FbTransaction transaction = con.BeginTransaction();

                    using (FbCommand command = new FbCommand(sqlScript, con))
                    {
                        command.Connection = con;
                        command.Transaction = transaction;

                        foreach (string sqlStatement in sqlScript.Split(';'))
                        {
                            if (!string.IsNullOrWhiteSpace(sqlStatement))
                            {
                                command.CommandText = sqlStatement;
                                command.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                    }
                    
                    MessageBox.Show("Dados inseridos e salvos no arquivo "+ System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "resultado.sql");
                }
                catch (FbException ex)
                {

                    MessageBox.Show("Ocorreu um erro: " + ex.Message); ;
                }

            }

        }

        public void BloquearCampos()
        {
            editNroLivro.Enabled = false;
            editNroPaginaInicialLivro.Enabled = false;
            editProtocoloFinal.Enabled = false;
            editProtocoloInicial.Enabled = false;
            editQtdPaginasLivro.Enabled = false;
            cbxFrenteVerso.Enabled = false;
            cbxInsereLivros.Enabled = false;
            cbxPassaLimiteFolha.Enabled = false;
            cbxLivroAB.Enabled = false;

            //desbloqueia botão corrigir e voltar
            btnCorrigir.Enabled = true;
            btnVoltar.Enabled = true;

        }

        public void DesbloquearCampos()
        {
            editNroLivro.Enabled = true;
            editNroPaginaInicialLivro.Enabled = true;
            editProtocoloFinal.Enabled = true;
            editProtocoloInicial.Enabled = true;
            editQtdPaginasLivro.Enabled = true;
            cbxFrenteVerso.Enabled = true;
            cbxInsereLivros.Enabled = true;
            cbxPassaLimiteFolha.Enabled = true;
            cbxLivroAB.Enabled = true;

            //bloqueia botão corrigir e voltar
            btnCorrigir.Enabled = false;
            btnVoltar.Enabled = false;

        }

        private void cbxInsereLivros_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(cbxInsereLivros, "Insere os livros criados no update.");
        }

        private void cbxPassaLimiteFolha_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(cbxPassaLimiteFolha, "Permite que as páginas ultapassem o número máxino do livro.");
        }

        private void cbxFrenteVerso_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(cbxFrenteVerso, "Gera sequência com páginas frente e verso.");
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja incluir os dados gerados?", "Corrigir Livros RTD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GravarLinhasDataTable(dataTable);
                UpdateBanco();
            }

        }

        private void btnBuscaDados_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnBuscaDados, "Busca e apresenta as páginas no grid.");
        }

        private void btnVoltar_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnVoltar, "Voltar para o cadastro de informações.");
        }

        private void btnCorrigir_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnCorrigir, "Corrige os protocolos e insere no banco de dados.");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            dtgResultado.Columns.Clear();
            dtgResultado.DataSource = null;

            dataTable.Clear(); 
            dataTable.Columns.Clear(); 

            DesbloquearCampos();
        }

        private void cbxInsereLivros_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxInsereLivros.Checked)
            {
                MessageBox.Show("Para utilizar esta função garanta que a tabela Livros esteja limpa!");
            }
            
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSobre form = new formSobre();
            form.ShowDialog();
        }
    }
}
