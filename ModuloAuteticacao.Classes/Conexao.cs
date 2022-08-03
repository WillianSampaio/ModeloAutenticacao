using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAuteticacao.Classes 
{
    internal class Conexao
    {
        public static SqlConnection _conn;


        //public int numero; 
        //public double PI = 34.67; 
        //public int idade = 31; 
        //int bolsa = 10; 
        //double nota = 70;

        public static SqlConnection MyProperty { get; set; }
        public static SqlConnection MinhaInstancia
        { //a chave da propriedade
            get
            { // chave do método get
              //se não existe conexão.
                if (_conn == null)
                { // chave do if
                    _conn = new SqlConnection(@"Server = Lab206_31; Database = ProjetoEstoque; Uid = sa; Pwd = teste*123;");

                } // fecha chave do if
                  //retorna a conexão
                return _conn;
            }
        }
    }
}
