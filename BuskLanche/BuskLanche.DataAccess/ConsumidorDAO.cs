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

        public bool ValidarCPF(string cpf)
        {
            string valor = cpf.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];
            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                return false;

            return true;
        }

        public bool ValidarEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
                return false;
            if (!email.Contains("@") || !email.Contains("."))
                return false;
            string[] strCamposEmail = email.Split(new String[] { "@" }, StringSplitOptions.RemoveEmptyEntries);
            if (strCamposEmail.Length != 2)
                return false;
            if (strCamposEmail[0].Length < 3)
                return false;
            if (!strCamposEmail[1].Contains("."))
                return false;
            strCamposEmail = strCamposEmail[1].Split(new String[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            if (strCamposEmail.Length < 2)
                return false;
            if (strCamposEmail[0].Length < 1)
                return false;
            return true;
        }
    }
}
