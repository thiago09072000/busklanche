using BuskLanche.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BuskLanche.DataAccess
{
    public class CardapioDAO
    {
        public void Inserir(Cardapio obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"INSERT INTO CadastroDeCardapio (idCadComercio, nome, ingrediente, preco) VALUES (@idCadComercio, @nome, @ingrediente, @preco);";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.Int).Value = obj.Comercio.Id;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = obj.Nome;
                    cmd.Parameters.Add("@ingrediente", SqlDbType.VarChar).Value = obj.Ingrediente;
                    cmd.Parameters.Add("@preco", SqlDbType.Decimal).Value = obj.Preco;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Atualizar(Cardapio obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"UPDATE CadastroDeCardapio SET idCadComercio = @idCadComercio, nome = @nome, ingrediente = @ingrediente, preco = @preco WHERE idCadCardapio = @idCadCardapio;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.Int).Value = obj.Comercio.Id;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = obj.Nome;
                    cmd.Parameters.Add("@ingrediente", SqlDbType.VarChar).Value = obj.Ingrediente;
                    cmd.Parameters.Add("@preco", SqlDbType.Decimal).Value = obj.Preco;
                    cmd.Parameters.Add("@idCadCardapio", SqlDbType.Int).Value = obj.Id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Excluir(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"DELETE FROM CadastroDeCardapio WHERE idCadCardapio = @idCadCardapio;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@idCadCardapio", SqlDbType.Int).Value = id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public Cardapio BuscarPorId(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM CadastroDeCardapio WHERE idCadCardapio = @idCadCardapio;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@idCadCardapio", SqlDbType.Int).Value = id;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    conn.Close();

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    var row = dt.Rows[0];
                    var cardapio = new Cardapio()
                    {
                        Id = Convert.ToInt32(row["idCadCardapio"]),
                        Comercio = new Comercio() { Id = Convert.ToInt32(row["idCadComercio"]) },
                        Nome = row["nome"].ToString(),
                        Ingrediente = row["ingrediente"].ToString(),
                        Preco = Convert.ToDecimal(row["preco"])
                    };

                    return cardapio;
                }
            }
        }

        public List<Cardapio> BuscarTodos()
        {
            var lstCardapio = new List<Cardapio>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM CadastroDeCardapio";

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
                        var Cardapio = new Cardapio()
                        {
                            Id = Convert.ToInt32(row["idCadCardapio"]),
                            Comercio = new Comercio() { Id = Convert.ToInt32(row["idCadComercio"]) },
                            Nome = row["nome"].ToString(),
                            Ingrediente = row["ingrediente"].ToString(),
                            Preco = Convert.ToDecimal(row["preco"])
                        };

                        lstCardapio.Add(Cardapio);
                    }
                }
            }

            return lstCardapio;
        }

        public List<Cardapio> BuscarPorComercio(int idCadComercio)
        {
            var lstCardapio = new List<Cardapio>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM CadastroDeCardapio WHERE idCadComercio = idCadComercio;";

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
                        var Cardapio = new Cardapio()
                        {
                            Id = Convert.ToInt32(row["idCadCardapio"]),
                            Comercio = new Comercio() { Id = Convert.ToInt32(row["idCadComercio"]) },
                            Nome = row["nome"].ToString(),
                            Ingrediente = row["ingrediente"].ToString(),
                            Preco = Convert.ToDecimal(row["preco"])
                        };

                        lstCardapio.Add(Cardapio);
                    }
                }
            }

            return lstCardapio;
        }
    }
}
