using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using Senai.WebApi.InLock.Carlos_Marcos.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Repository
{
    public class EstudioRepository : IEstudioRepository
{
        private string stringConexao = "Data Source = LAPTOP-N251D43S\\TEW_SQLEXPRESS; initial catalog=InLock_Games_Manha;integrated security = true;";
        //private string stringConexao = "Data Source=DESKTOP-GCOFA7F\\SQLEXPRESS; initial catalog=Filmes_manha; user Id=sa; pwd=sa@132";
       
        public void Cadastrar(EstudioDomain novoEstudio)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO NomeEstudio FROM Estudio";

                using(SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@NomeEstudio", novoEstudio.NomeEstudio);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<EstudioDomain> Listar()
        {
            List<EstudioDomain> tipoUsuarios = new List<EstudioDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT IdEstudio, NomeEstudio FROM Estudio";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmdd = new SqlCommand(querySelect, con))
                {
                    rdr = cmdd.ExecuteReader();

                    while (rdr.Read())
                    {
                        EstudioDomain tipoUsuario = new EstudioDomain()
                        {
                            IdEstudio = Convert.ToInt32(rdr[0]),
                            NomeEstudio = rdr["NomeEstudio"].ToString(),
                        };

                        tipoUsuarios.Add(tipoUsuario);

                    }
                }
            }
            return tipoUsuarios;
        }
    }
}
