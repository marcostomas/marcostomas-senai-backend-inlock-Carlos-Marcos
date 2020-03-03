using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Repository
{
    public class EstudioRepository
{
        private string stringConexao = "Data Source = LAPTOP-N251D43S\\TEW_SQLEXPRESS; initial catalog=M_Peoples;integrated security = true";
        //private string stringConexao = "Data Source=DESKTOP-GCOFA7F\\SQLEXPRESS; initial catalog=Filmes_manha; user Id=sa; pwd=sa@132";

        public List<EstudioDomain> Listar()
        {
            List<EstudioDomain> tipoUsuarios = new List<EstudioDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT * FROM";

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
                            NomeEstudio = rdr["Titulo"].ToString(),
                        };

                        tipoUsuarios.Add(tipoUsuario);

                    }
                }
            }
            return tipoUsuarios;
        }
    }
}
