using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Domain
{
    public class EstudioDomain
    {
        public int IdEstudio { get; set; }

        [Required(ErrorMessage = "O Nome do Estudio é obrigatório!")]
        public string NomeEstudio { get; set; }
    }
}
