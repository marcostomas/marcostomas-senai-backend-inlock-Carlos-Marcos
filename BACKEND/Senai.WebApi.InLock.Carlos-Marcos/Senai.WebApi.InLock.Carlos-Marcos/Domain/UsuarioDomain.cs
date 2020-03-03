using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WebApi.InLock.Carlos_Marcos.Domain
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Informe o Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a Senha")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "O campo senha precisa ter no minimo 3 caracteres")]
        public string Senha { get; set; }

        public int IdTipoUsuario { get; set; }
    }
}
