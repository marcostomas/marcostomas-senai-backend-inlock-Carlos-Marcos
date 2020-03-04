using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Domain
{
    public class JogosDomain
    {
        public int IdJogo { get; set; }

        [Required(ErrorMessage = "O Nome do Jogo é obrigatório!")]
        public string NomeJogo { get; set; }

        public string Descricao { get; set; }

        public string DataLancamento { get; set; }

        public double Valor { get; set; }

        [Required(ErrorMessage = "O Id do Estudio é obrigatório!")]
        public int IdEstudio { get; set; }
    }
}
