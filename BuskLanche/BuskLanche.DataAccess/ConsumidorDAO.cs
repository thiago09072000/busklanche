using BuskLanche.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BuskLanche.DataAccess
{
    public class ConsumidorDAO
    {
        public void Inserir(Consumidor obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
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

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
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

        public Consumidor Logar(string email, string senha)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM CadastroConsumidor WHERE emailConsumidor = @emailConsumidor and senhaConsumidor = @senhaConsumidor;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@emailConsumidor", SqlDbType.VarChar).Value = email;
                    cmd.Parameters.Add("@senhaConsumidor", SqlDbType.VarChar).Value = senha;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    conn.Close();

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    var row = dt.Rows[0];
                    var consumidor = new Consumidor()
                    {
                        Id = Convert.ToInt32(row["idCadConsumidor"]),
                        Nome = row["nomeConsumidor"].ToString(),
                        Email = row["emailConsumidor"].ToString(),
                        Senha = row["senhaConsumidor"].ToString(),
                        Cpf = row["cpfConsumidor"].ToString()
                    };

                    return consumidor;
                }
            }
        }
    }
}
