using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using Senai.WebApi.InLock.Carlos_Marcos.Interface;
using Senai.WebApi.InLock.Carlos_Marcos.Repository;

namespace Senai.WebApi.InLock.Carlos_Marcos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuariosController : ControllerBase
    {
        /// <summary>
        /// Cria um objeto _tipoUsuarioRepository que irá receber todos os métodos definidos na interface
        /// </summary>
        private ITipoUsuarioRepository _tipoUsuarioRepository { get; set; }

        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public TipoUsuariosController()
        {
            _tipoUsuarioRepository = new TipoUsuarioRepository();
        }

        /// <summary>
        /// Lista todos os tipos de usuário
        /// </summary>
        /// <returns>Retorna uma lista de tipos de usuário e um status code 200 - Ok</returns>
        /// dominio/api/TiposUsuario
        [HttpGet]
        public IActionResult Get()
        {
            // Faz a chamada para o método .Listar()
            // Retorna a lista e um status code 200 - Ok
            return Ok(_tipoUsuarioRepository.Listar());
        }

        /// <summary>
        /// Cadastra um novo tipo de usuário
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto novoTipoUsuario que será cadastrado</param>
        /// <returns>Retorna os dados que foram enviados para cadastro e um status code 201 - Created</returns>
        /// dominio/api/TiposUsuario
        //[HttpPost]
        //public IActionResult Post(TipoUsuarioDomain novoTipoUsuario)
        //{
            // Faz a chamada para o método .Cadastrar();
         //   _tipoUsuarioRepository.Cadastrar(novoTipoUsuario);

            // Retorna o status code 201 - Created com a URI e o objeto cadastrado
        //    return Created("http://localhost:5000/api/Usuarios", novoTipoUsuario);
        //}

       
    }
}