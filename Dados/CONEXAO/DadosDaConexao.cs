using System;

namespace Dados
{
    public class DadosDaConexao
    {
        public static String servidor = @"";
        public static String banco = "";
        public static String usuario = "";
        public static String senha = "";

        public static string conexao = "";

        //public static String StringDeConexao
        //{
        //    get
        //    {
        //        return @"Data Source =" + servidor + "; Initial Catalog = " + banco + "; Persist Security Info = True; User ID = " + usuario + "; Password = " + senha + ";";

        //        //Em rede
        //        //return @"Data Source=" + servidor + ";Initial Catalog=" + banco + "; MultipleActiveResultSets=True";

        //        //banco Local
        //        ////var caminho = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SistemaLoja.mdf");
        //        //var DestinationFile = System.IO.Path.Combine(@"C:\Banco\SistemaLoja.mdf");
        //        //return string.Format(@"Server = (localdb)\v11.0;Integrated Security = true;AttachDbFileName = {0};", DestinationFile);

        //        //Alterar ConnectionString no app.config
        //        //try
        //        //{
        //        //    conexao = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //        //}
        //        //catch (Exception)
        //        //{
        //        //    conexao = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        //        //}
        //        //return conexao;
        //        ///
        //        ////return @"Data Source =" + servidor + "; Initial Catalog = " + banco + "; Persist Security Info = True; User ID = " + usuario + "; Password = " + senha + "; ";

        //    }

        //}
        public string getWebConfig(string Variavel)
        {
            string strValue = "";
            strValue = System.Configuration.ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;

            return strValue;
        }

    }
}

