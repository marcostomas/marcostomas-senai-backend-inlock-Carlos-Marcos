﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Informe a Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
