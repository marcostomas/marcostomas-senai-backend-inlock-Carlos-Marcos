using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Interface
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Lista todos os tipos de usuario
        /// </summary>
        /// <returns></returns>
        List<UsuarioDomain> Listar();

        /// <summary>
        /// Cadastra Novos Usuarios
        /// </summary>
        /// <returns></returns>
        void Cadastrar(UsuarioDomain novoUsuario);
        UsuarioDomain BuscarPorEmailSenha(string email, string senha);
    }
}
