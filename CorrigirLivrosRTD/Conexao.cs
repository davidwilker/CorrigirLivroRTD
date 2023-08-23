using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;
using IniParser;
using IniParser.Model;

namespace CorrigirLivrosRTD
{
    public class Conexao
    {

        private static readonly Conexao Innstancia = new Conexao();

        private Conexao()
        {

        }

        public static Conexao PegarInstancia()
        {
            return Innstancia;
        }

        public FbConnection PegarConexao()
        {            

            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile(System.AppDomain.CurrentDomain.BaseDirectory.ToString()+"Config.ini");

            string caminho  = data["CONFIG"]["CAMINHO"];
            string servidor = data["CONFIG"]["SERVIDOR"];
            string porta    = data["CONFIG"]["PORTA"];

            string strConexao = "User=SYSDBA; PassWord=masterkey; Database=" + caminho + "; DataSource=" + servidor + "; Port=" + porta + ";";            

            return new FbConnection(strConexao);

        }

        public static bool TestarConexao()
        {
            bool resposta = true;


            using (FbConnection Con = Conexao.PegarInstancia().PegarConexao())
            {


                try
                {
                    Con.Open();

                }
                catch
                {
                    resposta = false;

                }
                finally
                {
                    Con.Close();
                }

            }

            return resposta;
        }

        public static void Configuracao()
        {

        }
    }
}
