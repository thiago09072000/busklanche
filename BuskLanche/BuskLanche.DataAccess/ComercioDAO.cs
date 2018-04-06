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
    public class ComercioDAO
    {
        public void Inserir(Comercio obj)
        {
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=BuskLanche; Data Source=localhost; Integrated Security=SSPI;"))
            {
                string strSQL = @"INSERT INTO CadastroConsumidor (cnpj, nomeComercio, bairro, rua, numero, cep, complemento, nomeRepresentante, emailRepresentante, senhaRepresentante, 
                                                                  cpfRepresentante, telefoneRepresentante, estiloDoLanche, horarioAbertura, horarioEnceramento, DescricaoComercio) 
                                                          VALUES (@cnpj, @nomeComercio, @bairro, @rua, @numero, @cep, @complemento, @nomeRepresentante, @emailRepresentante, @senhaRepresentante, 
                                                                  @cpfRepresentante, @telefoneRepresentante, @estiloDoLanche, @horarioAbertura, @horarioEnceramento, @DescricaoComercio)";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = obj.Cnpj;
                    cmd.Parameters.Add("@nomeComercio", SqlDbType.VarChar).Value = obj.NomeComercio;
                    cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = obj.Bairro;
                    cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = obj.Rua;
                    cmd.Parameters.Add("@numero", SqlDbType.Int).Value = obj.Numero;
                    cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = obj.Cep;
                    cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = obj.Complemeneto;
                    cmd.Parameters.Add("@nomeRepresentante", SqlDbType.VarChar).Value = obj.NomeRepresentante;
                    cmd.Parameters.Add("@emailRepresentante", SqlDbType.VarChar).Value = obj.EmailRepresentante;
                    cmd.Parameters.Add("@senhaRepresentante", SqlDbType.VarChar).Value = obj.SenhaRepresentante;
                    cmd.Parameters.Add("@cpfRepresentante", SqlDbType.VarChar).Value = obj.CpfRepresentante;
                    cmd.Parameters.Add("@telefoneRepresentante", SqlDbType.VarChar).Value = obj.TelefoneRepresentante;
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

        public List<Comercio> BuscarTodos()
        {
            var lstComercio = new List<Comercio>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=BuskLanche; Data Source=localhost; Integrated Security=SSPI;"))
            {
                string strSQL = @"SELECT * FROM CadastroComercio";

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
                            Complemeneto = row["complemento"].ToString(),
                            NomeRepresentante = row["nomeRepresentante"].ToString(),
                            EmailRepresentante = row["emailRepresentante"].ToString(),
                            SenhaRepresentante = row["senhaRepresentante"].ToString(),
                            CpfRepresentante = row["cpfRepresentante"].ToString(),
                            TelefoneRepresentante = row["telefoneRepresentante"].ToString(),
                            EstiloDoLanche = row["estiloDoLanche"].ToString(),
                            //HorarioAbertura
                            //HorarioEncerramento
                            DescricaoComercio = row["DescricaoComercio"].ToString()

                        };
                        lstComercio.Add(Comercio);
                    }
                }
            }

            return (lstComercio);
        }
    }
}
