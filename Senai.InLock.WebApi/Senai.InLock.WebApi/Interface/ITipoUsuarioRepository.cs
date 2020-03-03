using Senai.InLock.WebApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Interface
{
    public class ITipoUsuarioRepository
    {

        /// <summary>
        /// Lista todos os tipos de usuario
        /// </summary>
        /// <returns></returns>
        List<TipoUsuarioDomain> Listar();

        /// <summary>
        /// Cadastra um novo tipo de usuario
        /// </summary>
        /// <param name="novoTipoUsuario"></param>
        void Cadastrar(TipoUsuarioDomain novoTipoUsuario);

    }
}
