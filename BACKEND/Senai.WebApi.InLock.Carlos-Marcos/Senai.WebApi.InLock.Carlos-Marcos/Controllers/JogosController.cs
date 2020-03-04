using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using Senai.WebApi.InLock.Carlos_Marcos.Interface;
using Senai.WebApi.InLock.Carlos_Marcos.Repository;

namespace Senai.WebApi.InLock.Carlos_Marcos.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
   
    public class JogosController : ControllerBase
    {
        private IJogosRepository _jogosRepository { get; set; }

        public JogosController()
        {
            _jogosRepository = new JogosRepository();
        }

        //[Authorize(Roles = "1")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_jogosRepository.Listar());
        }


        [HttpPost]
        public IActionResult Post(JogosDomain novoJogo)
        {
            _jogosRepository.Cadastrar(novoJogo);

            return Created("http//localhost:5000/api/Jogos", novoJogo);
        }

    }
}