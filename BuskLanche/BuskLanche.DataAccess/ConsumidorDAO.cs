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
    class ConsumidorDAO
    {
        public void Inserir(Consumidor obj)
        {
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=BuskLanche; Data Source=localhost; Integrated Security=SSPI;"))
            {
                string strSQL = @"INSERT INTO CadastroConsumidor (nomeConsumidor, emailConsumidor, senhaConsumidor, cpfConsumidor) VALUES (@nomeConsumidor, @emailConsumidor, @senhaConsumidor, @cpfConsumidor)";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@nomeConsumidor", SqlDbType.VarChar).Value = obj.Nome;
                    cmd.Parameters.Add("@emailConsumidor", SqlDbType.VarChar).Value = obj.Email;
                    cmd.Parameters.Add("@senhaConsumidor", SqlDbType.VarChar).Value = obj.Senha;
                    cmd.Parameters.Add("@cpfConsumidor", SqlDbType.VarChar).Value = obj.Cpf;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
