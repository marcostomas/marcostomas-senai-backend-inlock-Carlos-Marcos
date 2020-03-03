using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using Senai.WebApi.InLock.Carlos_Marcos.Interface;

namespace Senai.WebApi.InLock.Carlos_Marcos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {
        /// <summary>
        /// Cria um objeto _tipoUsuarioRepository que irá receber todos os métodos definidos na interface
        /// </summary>
        private ITipoUsuarioRepository _tipoUsuarioRepository { get; set; }

        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public TipoUsuarioController()
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
        [HttpPost]
        public IActionResult Post(TipoUsuarioDomain novoTipoUsuario)
        {
            // Faz a chamada para o método .Cadastrar();
            _tipoUsuarioRepository.Cadastrar(novoTipoUsuario);

            // Retorna o status code 201 - Created com a URI e o objeto cadastrado
            return Created("http://localhost:5000/api/Funcionarios", novoTipoUsuario);
        }

        /// <summary>
        /// Busca um tipo de usuário através do seu ID
        /// </summary>
        /// <param name="id">ID do tipo de usuário que será buscado</param>
        /// <returns>Retorna um tipo de usuário buscado ou NotFound caso nenhum seja encontrado</returns>
        /// dominio/api/TiposUsuario/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Cria um objeto tipoUsuarioBuscado que irá receber o tipo de usuário buscado no banco de dados
            TipoUsuarioDomain tipoUsuarioBuscado = _tipoUsuarioRepository.BuscarPorId(id);

            // Verifica se algum tipo de usuário foi encontrado
            if (tipoUsuarioBuscado != null)
            {
                // Caso seja, retorna os dados buscados e um status code 200 - Ok
                return Ok(tipoUsuarioBuscado);
            }

            // Caso não seja, retorna um status code 404 - NotFound com a mensagem
            return NotFound("Nenhum tipo de usuário encontrado para o identificador informado");
        }
    }
}