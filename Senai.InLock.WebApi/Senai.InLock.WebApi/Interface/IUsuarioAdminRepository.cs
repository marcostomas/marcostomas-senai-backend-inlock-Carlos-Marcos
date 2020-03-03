using Senai.InLock.WebApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Interface
{
    interface IUsuarioAdminRepository 
    {
        void Cadastrar(UsuarioAdminDomain usuario);

        List<UsuarioAdminDomain> Listar();

        UsuarioAdminDomain BuscarPorEmailSenha(string email, string senha);

    }
}
