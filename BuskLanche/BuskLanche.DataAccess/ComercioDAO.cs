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
    class ComercioDAO
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
    }
}
