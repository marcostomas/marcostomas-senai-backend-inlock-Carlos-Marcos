using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using Senai.WebApi.InLock.Carlos_Marcos.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Repository
{
    public class JogosRepository : IJogosRepository
    {
        private string stringConexao = "Data Source = LAPTOP-N251D43S\\TEW_SQLEXPRESS; initial catalog=InLock_Games_Manha;integrated security = true;";
        //private string stringConexao = "Data Source=DESKTOP-GCOFA7F\\SQLEXPRESS; initial catalog=Filmes_manha; user Id=sa; pwd=sa@132";

        public void Cadastrar(JogosDomain novoJogo)
        {
            using(SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Jogos(NomeJogo, Descricao, DataLancamento, Valor,IdEstudio) VALUES (@NomeJogo, @Descricao, @DataLancamento, @Valor, @IdEstudio)";

                using(SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@NomeJogo", novoJogo.NomeJogo);
                    cmd.Parameters.AddWithValue("@Descricao", novoJogo.Descricao);
                    cmd.Parameters.AddWithValue("@DataLancamento", novoJogo.Descricao);
                    cmd.Parameters.AddWithValue("@Valor", novoJogo.Valor);
                    cmd.Parameters.AddWithValue("@IdEstudio", novoJogo.IdEstudio);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<JogosDomain> Listar()
        {
            List<JogosDomain> jogosEstudio = new List<JogosDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT IdJogo, NomeJogo, Descricao, DataLancamento,Valor, IdEstudio FROM Jogos";

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
                            NomeJogo = rdr["NomeJogo"].ToString(),
                            Descricao = rdr["Descricao"].ToString(),
                            //DataLancamento = Convert.ToDateTime(rdr["DataLancamento"]),
                            DataLancamento = rdr["DataLancamento"].ToString(),
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
