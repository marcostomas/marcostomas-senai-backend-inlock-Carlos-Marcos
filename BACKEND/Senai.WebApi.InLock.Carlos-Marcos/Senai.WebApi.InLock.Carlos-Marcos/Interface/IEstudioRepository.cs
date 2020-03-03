using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Interface
{
    interface IEstudioRepository
    {
        /// <summary>
        /// Lista todos os Estudios
        /// </summary>
        /// <returns></returns>
        List<EstudioDomain> Listar();

        /// <summary>
        /// Cadastra Novos Estudios
        /// </summary>
        /// <param name="novoTipoUsuario"></param>
        void Cadastrar(EstudioDomain novoTipoUsuario);
    }
}
