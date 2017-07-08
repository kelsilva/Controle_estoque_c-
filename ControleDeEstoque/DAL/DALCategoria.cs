using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DALCategoria
    {
        private DALConexao conexao;

        public DALCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCategoria modelo)

        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into categoria(cat_nome) values (@nome); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@nome",modelo.CatNome);
            conexao.Conectar();
            modelo.catCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

        }
        public void Alterar(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update categoria set cat_nome @nome where cat_cod = @codigo;";

            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.catCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
