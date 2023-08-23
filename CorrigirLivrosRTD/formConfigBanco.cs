using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace CorrigirLivrosRTD
{
    public partial class formConfigBanco : Form
    {
        public formConfigBanco()
        {
            InitializeComponent();
        }

        private void btnPesquisaBanco_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Configuração base de dados";
            openFileDialog1.Filter = "Bases Firebird|*.gdb";
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                editCaminhoBanco.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void btnSalvarConexao_Click(object sender, EventArgs e)
        {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "Config.ini");

            data["CONFIG"]["CAMINHO"] = editCaminhoBanco.Text;
            data["CONFIG"]["SERVIDOR"] = editServidor.Text;
            data["CONFIG"]["PORTA"] = editPorta.Text;

            parser.WriteFile("Config.ini", data);

            MessageBox.Show("Arquivo Salvo");
        }

        private void formConfigBanco_Load(object sender, EventArgs e)
        {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "Config.ini");

            editCaminhoBanco.Text = data["CONFIG"]["CAMINHO"];
            editServidor.Text = data["CONFIG"]["SERVIDOR"];
            editPorta.Text = data["CONFIG"]["PORTA"];
        }

        private void btnTesteConexao_Click(object sender, EventArgs e)
        {
            if (!Conexao.TestarConexao())
            {
                MessageBox.Show("Erro na conexão!");
            }
            else
            {
                MessageBox.Show("Banco "+editCaminhoBanco.Text +" Conectado");
            }
        }
    }
}
