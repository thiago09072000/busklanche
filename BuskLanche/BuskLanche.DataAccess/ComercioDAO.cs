using BuskLanche.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BuskLanche.DataAccess
{
    public class ComercioDAO
    {
        public int Inserir(Comercio obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"INSERT INTO CadastroComercio (cnpj, nomeComercio, bairro, rua, numero, cep, complemento, nomeRepresentante, emailRepresentante, senhaRepresentante, 
                                                                  cpfRepresentante, telefoneRepresentante, estiloDoLanche, horarioAbertura, horarioEnceramento, DescricaoComercio) 
                                                          VALUES (@cnpj, @nomeComercio, @bairro, @rua, @numero, @cep, @complemento, @nomeRepresentante, @emailRepresentante, @senhaRepresentante, 
                                                                  @cpfRepresentante, @telefoneRepresentante, @estiloDoLanche, @horarioAbertura, @horarioEnceramento, @DescricaoComercio);
                                 SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = obj.Cnpj;
                    cmd.Parameters.Add("@nomeComercio", SqlDbType.VarChar).Value = obj.NomeComercio;
                    cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = obj.Bairro ?? string.Empty;
                    cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = obj.Rua ?? string.Empty;
                    cmd.Parameters.Add("@numero", SqlDbType.Int).Value = obj.Numero;
                    cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = obj.Cep ?? string.Empty;
                    cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = obj.Complemento ?? string.Empty;
                    cmd.Parameters.Add("@nomeRepresentante", SqlDbType.VarChar).Value = obj.Nome ?? string.Empty;
                    cmd.Parameters.Add("@emailRepresentante", SqlDbType.VarChar).Value = obj.Email ?? string.Empty;
                    cmd.Parameters.Add("@senhaRepresentante", SqlDbType.VarChar).Value = obj.Senha ?? string.Empty;
                    cmd.Parameters.Add("@cpfRepresentante", SqlDbType.VarChar).Value = obj.CpfRepresentante ?? string.Empty;
                    cmd.Parameters.Add("@telefoneRepresentante", SqlDbType.VarChar).Value = obj.TelefoneRepresentante ?? string.Empty;
                    cmd.Parameters.Add("@estiloDoLanche", SqlDbType.VarChar).Value = obj.EstiloDoLanche ?? string.Empty;
                    cmd.Parameters.Add("@horarioAbertura", SqlDbType.VarChar).Value = obj.HorarioAbertura ?? string.Empty;
                    cmd.Parameters.Add("@horarioEnceramento", SqlDbType.VarChar).Value = obj.HorarioEncerramento ?? string.Empty;
                    cmd.Parameters.Add("@DescricaoComercio", SqlDbType.VarChar).Value = obj.DescricaoComercio ?? string.Empty;

                    conn.Open();
                    obj.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    return obj.Id;
                }
            }
        }

        public void Atualizar2(Comercio obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"UPDATE CadastroComercio SET
                                    bairro = @bairro,
                                    rua = @rua,
                                    numero = @numero,
                                    cep = @cep,
                                    complemento = @complemento
                                 WHERE idCadComercio = @idCadComercio;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = obj.Bairro;
                    cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = obj.Rua;
                    cmd.Parameters.Add("@numero", SqlDbType.Int).Value = obj.Numero;
                    cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = obj.Cep;
                    cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = obj.Complemento;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.Int).Value = obj.Id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Atualizar3(Comercio obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"UPDATE CadastroComercio SET
                                    nomeRepresentante = @nomeRepresentante,
                                    emailRepresentante = @emailRepresentante,
                                    senhaRepresentante = @senhaRepresentante,
                                    cpfRepresentante = @cpfRepresentante,
                                    telefoneRepresentante = @telefoneRepresentante
                                 WHERE idCadComercio = @idCadComercio;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@nomeRepresentante", SqlDbType.VarChar).Value = obj.Nome;
                    cmd.Parameters.Add("@emailRepresentante", SqlDbType.VarChar).Value = obj.Email;
                    cmd.Parameters.Add("@senhaRepresentante", SqlDbType.VarChar).Value = obj.Senha;
                    cmd.Parameters.Add("@cpfRepresentante", SqlDbType.VarChar).Value = obj.CpfRepresentante;
                    cmd.Parameters.Add("@telefoneRepresentante", SqlDbType.VarChar).Value = obj.TelefoneRepresentante;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.Int).Value = obj.Id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Atualizar4(Comercio obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"UPDATE CadastroComercio SET
                                    estiloDoLanche = @estiloDoLanche,
                                    horarioAbertura = @horarioAbertura,
                                    horarioEnceramento = @horarioEnceramento,
                                    DescricaoComercio = @DescricaoComercio
                                 WHERE idCadComercio = @idCadComercio;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@estiloDoLanche", SqlDbType.VarChar).Value = obj.EstiloDoLanche;
                    cmd.Parameters.Add("@horarioAbertura", SqlDbType.VarChar).Value = obj.HorarioAbertura;
                    cmd.Parameters.Add("@horarioEnceramento", SqlDbType.VarChar).Value = obj.HorarioEncerramento;
                    cmd.Parameters.Add("@DescricaoComercio", SqlDbType.VarChar).Value = obj.DescricaoComercio;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.Int).Value = obj.Id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void AlterarDados(Comercio obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"UPDATE CadastroComercio SET
                                    nomeComercio = @nomeComercio,
                                    cnpj = @cnpj,
                                    bairro = @bairro,
                                    rua = @rua,
                                    numero = @numero,
                                    cep = @cep,
                                    complemento = @complemento,
                                    estiloDoLanche = @estiloDoLanche,
                                    horarioAbertura = @horarioAbertura,
                                    horarioEnceramento = @horarioEnceramento,
                                    DescricaoComercio = @DescricaoComercio
                                 WHERE idCadComercio = @idCadComercio;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@nomeComercio", SqlDbType.VarChar).Value = obj.NomeComercio;
                    cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = obj.Cnpj;
                    cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = obj.Bairro;
                    cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = obj.Rua;
                    cmd.Parameters.Add("@numero", SqlDbType.Int).Value = obj.Numero;
                    cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = obj.Cep;
                    cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = obj.Complemento;
                    cmd.Parameters.Add("@estiloDoLanche", SqlDbType.VarChar).Value = obj.EstiloDoLanche;
                    cmd.Parameters.Add("@horarioAbertura", SqlDbType.VarChar).Value = obj.HorarioAbertura;
                    cmd.Parameters.Add("@horarioEnceramento", SqlDbType.VarChar).Value = obj.HorarioEncerramento;
                    cmd.Parameters.Add("@DescricaoComercio", SqlDbType.VarChar).Value = obj.DescricaoComercio;

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
                string strSQL = @"DELETE FROM CadastroComercio WHERE idCadComercio = @idCadComercio;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.Int).Value = id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public Comercio Logar(string email, string senha)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM CadastroComercio WHERE emailRepresentante = @emailRepresentante and senhaRepresentante = @senhaRepresentante;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@emailRepresentante", SqlDbType.VarChar).Value = email;
                    cmd.Parameters.Add("@senhaRepresentante", SqlDbType.VarChar).Value = senha;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    conn.Close();

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    var row = dt.Rows[0];
                    var comercio = new Comercio()
                    {
                        Id = Convert.ToInt32(row["idCadComercio"]),
                        Cnpj = row["cnpj"].ToString(),
                        NomeComercio = row["nomeComercio"].ToString(),
                        Bairro = row["bairro"].ToString(),
                        Rua = row["rua"].ToString(),
                        Numero = Convert.ToInt32(row["numero"]),
                        Cep = row["cep"].ToString(),
                        Complemento = row["complemento"].ToString(),
                        Nome = row["nomeRepresentante"].ToString(),
                        Email = row["emailRepresentante"].ToString(),
                        Senha = row["senhaRepresentante"].ToString(),
                        CpfRepresentante = row["cpfRepresentante"].ToString(),
                        TelefoneRepresentante = row["telefoneRepresentante"].ToString(),
                        EstiloDoLanche = row["estiloDoLanche"].ToString(),
                        HorarioAbertura = row["horarioAbertura"].ToString(),
                        HorarioEncerramento = row["horarioEnceramento"].ToString(),
                        DescricaoComercio = row["DescricaoComercio"].ToString()

                    };

                    return comercio;
                }
            }
        }

        public Comercio BuscarPorId(int idCadComercio)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT 
                                    *, 
                                    coalesce((select cast(avg(cast(avaliacao as decimal(15,2))) as decimal(15,2)) as media_nota from Avaliacoes where idCadComercio = CadastroComercio.idCadComercio), 0) as media_nota
                                FROM CadastroComercio WHERE idCadComercio = @idCadComercio;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.VarChar).Value = idCadComercio;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    conn.Close();

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    var row = dt.Rows[0];
                    var comercio = new Comercio()
                    {
                        Id = Convert.ToInt32(row["idCadComercio"]),
                        Cnpj = row["cnpj"].ToString(),
                        NomeComercio = row["nomeComercio"].ToString(),
                        Bairro = row["bairro"].ToString(),
                        Rua = row["rua"].ToString(),
                        Numero = Convert.ToInt32(row["numero"]),
                        Cep = row["cep"].ToString(),
                        Complemento = row["complemento"].ToString(),
                        Nome = row["nomeRepresentante"].ToString(),
                        Email = row["emailRepresentante"].ToString(),
                        Senha = row["senhaRepresentante"].ToString(),
                        CpfRepresentante = row["cpfRepresentante"].ToString(),
                        TelefoneRepresentante = row["telefoneRepresentante"].ToString(),
                        EstiloDoLanche = row["estiloDoLanche"].ToString(),
                        HorarioAbertura = row["horarioAbertura"].ToString(),
                        HorarioEncerramento = row["horarioEnceramento"].ToString(),
                        DescricaoComercio = row["DescricaoComercio"].ToString(),
                        NotaMedia = Convert.ToDecimal(row["media_nota"])
                    };

                    return comercio;
                }
            }
        }

        public List<Comercio> BuscarTodos()
        {
            var lstComercio = new List<Comercio>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT 
                                      *,
                                      coalesce((select cast(avg(cast(avaliacao as decimal(15,2))) as decimal(15,2)) as media_nota from Avaliacoes where idCadComercio = CadastroComercio.idCadComercio), 0) as media_nota
                                  FROM CadastroComercio";

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
                        var Comercio = new Comercio()
                        {
                            Id = Convert.ToInt32(row["idCadComercio"]),
                            Cnpj = row["cnpj"].ToString(),
                            NomeComercio = row["nomeComercio"].ToString(),
                            Bairro = row["bairro"].ToString(),
                            Rua = row["rua"].ToString(),
                            Numero = Convert.ToInt32(row["numero"]),
                            Cep = row["cep"].ToString(),
                            Complemento = row["complemento"].ToString(),
                            Nome = row["nomeRepresentante"].ToString(),
                            Email = row["emailRepresentante"].ToString(),
                            Senha = row["senhaRepresentante"].ToString(),
                            CpfRepresentante = row["cpfRepresentante"].ToString(),
                            TelefoneRepresentante = row["telefoneRepresentante"].ToString(),
                            EstiloDoLanche = row["estiloDoLanche"].ToString(),
                            HorarioAbertura = row["horarioAbertura"].ToString(),
                            HorarioEncerramento = row["horarioEnceramento"].ToString(),
                            DescricaoComercio = row["DescricaoComercio"].ToString(),
                            NotaMedia = Convert.ToDecimal(row["media_nota"])
                        };

                        lstComercio.Add(Comercio);
                    }
                }
            }

            return (lstComercio);
        }

        public List<Comercio> BuscarPorCep(string cep)
        {
            var lstComercio = new List<Comercio>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT 
                                    *,
                                    coalesce((select cast(avg(cast(avaliacao as decimal(15,2))) as decimal(15,2)) as media_nota from Avaliacoes where idCadComercio = CadastroComercio.idCadComercio), 0) as media_nota
                                FROM CadastroComercio WHERE cep = @cep;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = cep ?? string.Empty;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    conn.Close();

                    foreach (DataRow row in dt.Rows)
                    {
                        var Comercio = new Comercio()
                        {
                            Id = Convert.ToInt32(row["idCadComercio"]),
                            Cnpj = row["cnpj"].ToString(),
                            NomeComercio = row["nomeComercio"].ToString(),
                            Bairro = row["bairro"].ToString(),
                            Rua = row["rua"].ToString(),
                            Numero = Convert.ToInt32(row["numero"]),
                            Cep = row["cep"].ToString(),
                            Complemento = row["complemento"].ToString(),
                            Nome = row["nomeRepresentante"].ToString(),
                            Email = row["emailRepresentante"].ToString(),
                            Senha = row["senhaRepresentante"].ToString(),
                            CpfRepresentante = row["cpfRepresentante"].ToString(),
                            TelefoneRepresentante = row["telefoneRepresentante"].ToString(),
                            EstiloDoLanche = row["estiloDoLanche"].ToString(),
                            HorarioAbertura = row["horarioAbertura"].ToString(),
                            HorarioEncerramento = row["horarioEnceramento"].ToString(),
                            DescricaoComercio = row["DescricaoComercio"].ToString(),
                            NotaMedia = Convert.ToDecimal(row["media_nota"])
                        };

                        lstComercio.Add(Comercio);
                    }
                }
            }

            return (lstComercio);
        }

        
    }
}
