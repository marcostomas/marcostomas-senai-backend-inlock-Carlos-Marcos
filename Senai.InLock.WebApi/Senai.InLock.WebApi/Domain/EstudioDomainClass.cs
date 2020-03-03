using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domain
{
    public class EstudioDomainClass
    {
        public int IdEstudio { get; set; }

        [Required(ErrorMessage = "O Nome do Estudio é obrigatório!")]
        public string NomeEstudio { get; set; }
    }
}
