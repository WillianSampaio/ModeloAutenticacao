using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloAuteticacao.Classes
{
    public class NivelDAO
    {
        public string Inserir(string nome)
        {
            Conexao.MinhaInstancia.Open();
            SqlCommand command = Conexao.MinhaInstancia.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            //iniciando DML
            command.CommandText = "INSERT INTO Nivel(Nome)Values(@Nome)";
            //Adicionando parâmetro contra SQL Injection
            command.Parameters.Add(new SqlParameter("@Nome", nome));
            //Esta tudo pronto! Vamos executar o comando. 
            command.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();

            return "Você vai inserir";
        }
        public string Atualizar()
        {
            return "Você vai atualizar";
        }
        public string Pesquisar()
        {
            return "Você vai pesquisar";
        }
        public string Deletar()
        {
            return "Você vai deletar";
        }



    }

}

    

