using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using Senai.WebApi.InLock.Carlos_Marcos.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Repository
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
{
        private string stringConexao = "Data Source = LAPTOP-N251D43S\\TEW_SQLEXPRESS; initial catalog=InLock_Games_Manha;integrated security = true;";

        //public void Cadastrar(TipoUsuarioDomain novoTipoUsuario)
        //{
        //    throw new NotImplementedException();
        //}

        //private string stringConexao = "Data Source=DESKTOP-GCOFA7F\\SQLEXPRESS; initial catalog=Filmes_manha; user Id=sa; pwd=sa@132";

        public List<TipoUsuarioDomain> Listar()
        {
            List<TipoUsuarioDomain> tipoUsuarios = new List<TipoUsuarioDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT IdTipoUsuario, Titulo FROM TipoUsuarios";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmdd = new SqlCommand(querySelect, con))
                {
                    rdr = cmdd.ExecuteReader();

                    while (rdr.Read())
                    {
                        TipoUsuarioDomain tipoUsuario = new TipoUsuarioDomain()
                        {
                            IdTipoUsuario = Convert.ToInt32(rdr[0]),
                            Titulo = rdr["Titulo"].ToString(),
                        };

                        tipoUsuarios.Add(tipoUsuario);

                    }
                }
            }
            return tipoUsuarios;
        }
    }
}
