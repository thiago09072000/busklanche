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
    public class ConsumidorDAO
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

        public List<Consumidor> BuscarTodos()
        {
            var lstConsumidor = new List<Consumidor>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=BuskLanche; Data Source=localhost; Integrated Security=SSPI;"))
            {
                string strSQL = @"SELECT * FROM CadastroConsumidor";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);

                    conn.Close();

                    foreach (DataRow row in dt.Rows)
                    {
                        var Consumidor = new Consumidor()
                        {
                            Id = Convert.ToInt32(row["idCadConsumidor"]),
                            Nome = row["nomeConsumidor"].ToString(),
                            Email = row["emailConsumidor"].ToString(),
                            Senha = row["senhaConsumidor"].ToString(),
                            Cpf = row["cpfConsumidor"].ToString()

                        };
                        lstConsumidor.Add(Consumidor);
                    }
                }
            }

            return (lstConsumidor);
        }
    }
}
