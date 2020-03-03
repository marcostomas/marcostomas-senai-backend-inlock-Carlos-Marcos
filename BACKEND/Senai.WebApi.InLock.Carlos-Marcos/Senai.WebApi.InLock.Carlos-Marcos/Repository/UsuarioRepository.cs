using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using Senai.WebApi.InLock.Carlos_Marcos.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Repository
{
    public class UsuarioRepository : IUsuarioRepository
{
        //private string stringConexao = "Data Source=DESKTOP-GCOFA7F\\SQLEXPRESS; initial catalog=Filmes_manha; user Id=sa; pwd=sa@132";
        private string stringConexao = "Data Source = LAPTOP-N251D43S\\TEW_SQLEXPRESS; initial catalog=M_Peoples;integrated security = true";

        public UsuarioDomain BuscarPorEmailSenha(string email, string senha)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT";

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        UsuarioDomain usuario = new UsuarioDomain();

                        while (rdr.Read())
                        {
                            usuario.IdUsuario = Convert.ToInt32(rdr["IdUsuario"]);

                            usuario.Email = rdr["Email"].ToString();

                            usuario.Senha = rdr["Senha"].ToString();

                        }
                        return usuario;
                    }
                }
                return null;
            }
        }

        public void Cadastrar(UsuarioDomain novoUsuario)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioDomain> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
