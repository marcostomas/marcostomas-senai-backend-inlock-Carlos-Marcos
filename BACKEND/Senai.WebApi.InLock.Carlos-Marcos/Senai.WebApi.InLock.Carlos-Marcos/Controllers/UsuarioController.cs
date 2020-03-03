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

namespace senai.Peoples.WebApi.Controllers
{
    /// <summary>
    /// Controller responsável pelos endpoints referentes aos usuários
    /// </summary>

    // Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]
    // Define que a rota de uma requisição será no formato domínio/api/NomeController
    [Route("api/[controller]")]
    // Define que é um controlador de API
    [ApiController]

    // Define que somente usuários logados possam acessar os endpoints
    [Authorize]
    public class UsuariosController : ControllerBase
    {
        /// <summary>
        /// Cria um objeto _usuarioRepository que irá receber todos os métodos definidos na interface
        /// </summary>
        private IUsuarioRepository _usuarioRepository { get; set; }

        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Retorna uma lista de usuários e um status code 200 - Ok</returns>
        /// dominio/api/Usuarios
        [Authorize(Roles = "1")]    // Somente o tipo de usuário 1 (administrador) pode acessar o endpoint
        [HttpGet]
        public IActionResult Get()
        {
            // Faz a chamada para o método .Listar()
            // Retorna a lista e um status code 200 - Ok
            return Ok(_usuarioRepository.Listar());
        }


        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario que será cadastrado</param>
        /// <returns>Retorna os dados que foram enviados para cadastro e um status code 201 - Created</returns>
        /// dominio/api/Usuarios
        [HttpPost]
        public IActionResult Post(UsuarioDomain novoUsuario)
        {
            // Faz a chamada para o método .Cadastrar();
            _usuarioRepository.Cadastrar(novoUsuario);

            // Retorna o status code 201 - Created com a URI e o objeto cadastrado
            return Created("http://localhost:5000/api/Funcionarios", novoUsuario);
        }

    }
}