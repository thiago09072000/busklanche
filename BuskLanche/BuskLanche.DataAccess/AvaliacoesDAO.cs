using BuskLanche.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BuskLanche.DataAccess
{
    public class AvaliacoesDAO
    {
        public void Inserir(Avaliacoes obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"INSERT INTO Avaliacoes (idCadComercio, idCadConsumidor, avaliacao, comentario, dataHora) VALUES (@idCadComercio, @idCadConsumidor, @avaliacao, @comentario, @dataHora)";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.Int).Value = obj.IdComercio;
                    cmd.Parameters.Add("@idCadConsumidor", SqlDbType.Int).Value = obj.IdConsumidor;
                    cmd.Parameters.Add("@avaliacao", SqlDbType.VarChar).Value = obj.Avaliacao;
                    cmd.Parameters.Add("@comentario", SqlDbType.VarChar).Value = obj.Comentario;
                    cmd.Parameters.Add("@dataHora", SqlDbType.DateTime).Value = obj.DataHora;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public List<Avaliacoes> BuscarTodos()
        {
            var lstAvaliacoes = new List<Avaliacoes>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM Avaliacoes";

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
                        var Avaliacoes = new Avaliacoes()
                        {
                            Id = Convert.ToInt32(row["id"]),
                            IdComercio = new Comercio()
                            {
                                Id = Convert.ToInt32(row["idCadComercio"]),
                                NomeComercio = row["nomeComercio"].ToString()
                            },
                            IdConsumidor = new Consumidor()
                            {
                                Id = Convert.ToInt32(row["idCadConsumidor"]),
                                Nome = row["nomeConsumidor"].ToString()
                            },
                            Avaliacao = row["avaliacao"].ToString(),
                            Comentario = row["comentario"].ToString()
                        };
                        lstAvaliacoes.Add(Avaliacoes);
                    }
                }
            }

            return (lstAvaliacoes);
        }

        public List<Avaliacoes> BuscaID(int IdCadComercio)
        {
            var lstAvaliacoes = new List<Avaliacoes>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM Avaliacoes WHERE idCadComercio = @idCadComercio ";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.Int).Value = IdCadComercio;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);

                    conn.Close();

                    foreach (DataRow row in dt.Rows)
                    {
                        var Avaliacoes = new Avaliacoes()
                        {
                            Id = Convert.ToInt32(row["id"]),
                            IdComercio = new Comercio()
                            {
                                Id = Convert.ToInt32(row["idCadComercio"]),
                                NomeComercio = row["nomeComercio"].ToString()
                            },
                            IdConsumidor = new Consumidor()
                            {
                                Id = Convert.ToInt32(row["idCadConsumidor"]),
                                Nome = row["nomeConsumidor"].ToString()
                            },
                            Avaliacao = row["avaliacao"].ToString(),
                            Comentario = row["comentario"].ToString()
                    };
                        lstAvaliacoes.Add(Avaliacoes);
                    }
                }
            }
            return (lstAvaliacoes);
        }
    }
}
