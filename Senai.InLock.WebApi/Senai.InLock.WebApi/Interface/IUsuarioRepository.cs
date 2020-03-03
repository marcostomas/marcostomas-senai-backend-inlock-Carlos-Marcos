using Senai.InLock.WebApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Interface
{
    interface IUsuarioRepository 
    {
        void Cadastrar(UsuarioDomain usuario);

        List<UsuarioDomain> Listar();

        UsuarioDomain BuscarPorEmailSenha(string email, string senha);

    }
}
