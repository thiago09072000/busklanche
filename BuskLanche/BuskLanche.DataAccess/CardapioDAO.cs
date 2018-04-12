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
    public class CardapioDAO
    {
        public void Inserir(Cardapio obj)
        {
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=BuskLanche; Data Source=localhost; Integrated Security=SSPI;"))
            {
                string strSQL = @"INSERT INTO CadastroDeCardapio (idCadComercio,nome,ingrediente,preco) VALUES (@idCadComercio,@nome,@ingrediente,preco)";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.Int).Value = obj.IdComercio;
                    cmd.Parameters.Add("@nome", SqlDbType.Int).Value = obj.Nome;
                    cmd.Parameters.Add("@ingrediente", SqlDbType.VarChar).Value = obj.Ingrediente;
                    cmd.Parameters.Add("@preco", SqlDbType.VarChar).Value = obj.Preco;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public List<Cardapio> BuscarTodos()
        {
            var lstCardapio = new List<Cardapio>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=BuskLanche; Data Source=localhost; Integrated Security=SSPI;"))
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
                            Nome = row["nome"].ToString(),
                            Ingrediente = row["ingrediente"].ToString(),
                            Preco = row["preco"].ToString()
                            
                        };
                        lstCardapio.Add(Cardapio);
                    }
                }
            }

            return (lstCardapio);
        }
    }
}
