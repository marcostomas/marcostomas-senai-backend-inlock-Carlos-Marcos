using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Repository
{
    public class JogosRepository
    {
        private string stringConexao = "Data Source = LAPTOP-N251D43S\\TEW_SQLEXPRESS; initial catalog=M_Peoples;integrated security = true";
        //private string stringConexao = "Data Source=DESKTOP-GCOFA7F\\SQLEXPRESS; initial catalog=Filmes_manha; user Id=sa; pwd=sa@132";

        public List<JogosDomain> Listar()
        {
            List<JogosDomain> jogosEstudio = new List<JogosDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT * FROM";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        JogosDomain jogo = new JogosDomain()
                        {
                            IdJogo = Convert.ToInt32(rdr[0]),
                            NomeJogo = rdr["Titulo"].ToString(),
                            Descricao = rdr["Descricao"].ToString(),
                            DataLancamento = Convert.ToDateTime(rdr["DataLancamento"]),
                            Valor = Convert.ToDouble(rdr[4]),
                            IdEstudio = Convert.ToInt32(rdr[5]),
                        };

                        jogosEstudio.Add(jogo);

                    }
                }
            }
            return jogosEstudio;
        }
    }
}
