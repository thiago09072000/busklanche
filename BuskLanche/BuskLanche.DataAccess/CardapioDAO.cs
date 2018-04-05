using BuskLanche.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuskLanche.DataAccess
{
    class CardapioDAO
    {
        public void Inserir(Cardapio obj)
        {
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=BuskLanche; Data Source=localhost; Integrated Security=SSPI;"))
            {
                string strSQL = @"INSERT INTO CadastroDeCardapio (idCadComercio,nome,ingrediente,preco) VALUES (@idCadComercio,@nome,@ingrediente,preco)";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.Int).Value = obj.IdComercio;
                    cmd.Parameters.Add("@nome", SqlDbType.Int).Value = obj.Nome;
                    cmd.Parameters.Add("@ingrediente", SqlDbType.VarChar).Value = obj.Ingrediente;
                    cmd.Parameters.Add("@preco", SqlDbType.VarChar).Value = obj.Preco;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
}
