using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Interface
{
    interface ITipoUsuarioRepository
{
        /// <summary>
        /// Lista todos os tipos de usuario
        /// </summary>
        /// <returns></returns>
        List<TipoUsuarioDomain> Listar();
    }
}
