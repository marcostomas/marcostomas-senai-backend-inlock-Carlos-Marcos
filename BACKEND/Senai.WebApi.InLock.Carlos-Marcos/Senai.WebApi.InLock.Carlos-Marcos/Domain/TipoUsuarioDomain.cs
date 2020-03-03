using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Domain
{
    public class TipoUsuarioDomain
    {
        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O Titulo é obrigatório!")]
        public string Titulo { get; set; }
    }
}
