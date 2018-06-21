using BuskLanche.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

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

        public bool ValidarCNPJ(string cnpj)
        {
            string vCNPJ = cnpj.Replace(".", "");
            vCNPJ = vCNPJ.Replace("/", "");
            vCNPJ = vCNPJ.Replace("-", "");

            int[] digitos, soma, resultado;
            int nrDig;
            string ftmt;
            bool[] CNPJOk;

            ftmt = "6543298765432";
            digitos = new int[14];
            soma = new int[2];
            soma[0] = 0;
            soma[1] = 0;
            resultado = new int[2];
            resultado[0] = 0;
            resultado[1] = 0;
            CNPJOk = new bool[2];
            CNPJOk[0] = false;
            CNPJOk[1] = false;

            try
            {
                for (nrDig = 0; nrDig < 14; nrDig++)
                {
                    digitos[nrDig] = int.Parse(vCNPJ.Substring(nrDig, 1));
                    if (nrDig <= 11)
                        soma[0] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1)));
                    if (nrDig <= 12)
                        soma[1] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1)));
                }

                for (nrDig = 0; nrDig < 2; nrDig++)
                {
                    resultado[nrDig] = (soma[nrDig] % 11);
                    if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                        CNPJOk[nrDig] = (digitos[12 + nrDig] == 0);
                    else
                        CNPJOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));
                }
                return (CNPJOk[0] && CNPJOk[1]);
            }
            catch
            {
                return false;
            }
        }

        public bool ValidarCEP(string cep)
        {
            if (String.IsNullOrEmpty(cep))
                return false;
            cep = cep.Replace(".", "").Replace("-", "");
            if (cep.Length == 8)
                cep = cep.Substring(0, 5) + "-" + cep.Substring(5, 3);
            return Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
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
