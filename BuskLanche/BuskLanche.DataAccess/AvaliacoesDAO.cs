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
    class AvaliacoesDAO
    {
        public void Inserir(Avaliacoes obj)
        {
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=BuskLanche; Data Source=localhost; Integrated Security=SSPI;"))
            {
                string strSQL = @"INSERT INTO Avaliacoes (idCadComercio, idCadConsumidao, avaliacao, comentario) VALUES (@idCadComercio, @idCadConsumidao, @avaliacao, @comentario)";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@idCadComercio", SqlDbType.Int).Value = obj.IdComercio;
                    cmd.Parameters.Add("@idCadConsumidao", SqlDbType.Int).Value = obj.IdConsumidor;
                    cmd.Parameters.Add("@avaliacao", SqlDbType.VarChar).Value = obj.Avalicacao;
                    cmd.Parameters.Add("@comentario", SqlDbType.VarChar).Value = obj.Comertario;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
