using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Interface
{
    interface IJogosRepository
    {
        /// <summary>
        /// Lista todos os jogos
        /// </summary>
        /// <returns></returns>
        List<JogosDomain> Listar();

        /// <summary>
        /// Cadastra novos jogos
        /// </summary>
        /// <return></return>
        void Cadastrar(JogosDomain novoJogo);
    }
}
