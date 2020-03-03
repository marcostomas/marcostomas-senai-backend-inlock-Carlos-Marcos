using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domain
{
    public class JogosDomain
    {
        public int IdJogo { get; set; }

        [Required(ErrorMessage = "O Nome do Jogo é obrigatório!")]
        public string NomeJogo { get; set; }

        public string Descricao { get; set; }

        public DateTime Valor { get; set; }

        [Required(ErrorMessage = "O Id do Estudio é obrigatório!")]
        public int IdEstudio { get; set; }
    }
}
