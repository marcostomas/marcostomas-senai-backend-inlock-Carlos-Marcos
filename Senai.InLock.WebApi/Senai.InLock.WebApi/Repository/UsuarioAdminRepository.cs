using Senai.InLock.WebApi.Domain;
using Senai.InLock.WebApi.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repository
{
    public class UsuarioAdminRepository : IUsuarioAdminRepository
    {
        //private string stringConexao = "Data Source=DESKTOP-GCOFA7F\\SQLEXPRESS; initial catalog=Filmes_manha; user Id=sa; pwd=sa@132";
        private string stringConexao = "Data Source = LAPTOP-N251D43S\\TEW_SQLEXPRESS; initial catalog=M_Peoples;integrated security = true";

        public UsuarioAdminDomain BuscarPorEmailSenha(string email, string senha)
        {
           using(SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT";

                using(SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if(rdr.HasRows)
                    {
                        UsuarioAdminDomain usuario = new UsuarioAdminDomain();

                        while(rdr.Read())
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


        public void Cadastrar(UsuarioAdminDomain usuario)
        {
            using(SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Usuario (Email, Senha) VALUES (@Email, @Senha)";

                using (SqlCommand cmd = new SqlCommand(queryInsert))
                {
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@Senha", usuario.Senha);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<UsuarioAdminDomain> Listar()
        {
            List<UsuarioAdminDomain> usuarios = new List<UsuarioAdminDomain>();

            using(SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT * FROM ";

                con.Open();

                SqlDataReader rdr;

                using(SqlCommand cmd = new SqlCommand(querySelect,con))
                {
                    rdr = cmd.ExecuteReader();

                    while(rdr.Read())
                    {
                        UsuarioAdminDomain usuario = new UsuarioAdminDomain()
                        {
                            IdUsuario = Convert.ToInt32(rdr[0]),
                            Email = rdr["Email"].ToString(),
                            Senha = rdr["Senha"].ToString()
                        };

                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }
    }
}
