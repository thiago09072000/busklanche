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
                string strSQL = @"INSERT INTO CadastroDeCardapio (idCadComercio,nome,ingrediente,preco) VALUES (@idCadComercio,@nome,@ingrediente,preco)";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.Int).Value = obj.IdComercio;
                    cmd.Parameters.Add("@nome", SqlDbType.Int).Value = obj.Nome;
                    cmd.Parameters.Add("@ingrediente", SqlDbType.VarChar).Value = obj.Ingrediente;
                    cmd.Parameters.Add("@preco", SqlDbType.Decimal).Value = obj.Preco;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Alterar(Cardapio obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"";
            }
        }

        public void Excluir(Cardapio obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {

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
                            IdComercio = new Comercio() { Id = Convert.ToInt32(row["idCadComercio"]) },
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
                            IdComercio = new Comercio() { Id = Convert.ToInt32(row["idCadComercio"]) },
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
