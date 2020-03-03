using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Senai.WebApi.InLock.Carlos_Marcos.Domain;
using Senai.WebApi.InLock.Carlos_Marcos.Interface;
using Senai.WebApi.InLock.Carlos_Marcos.Repository;
using Senai.WebApi.InLock.Carlos_Marcos.ViewModel;

namespace Senai.WebApi.InLock.Carlos_Marcos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
 

        private IUsuarioRepository _usuarioRepository { get; set; }



        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(LoginViewModel login)
        {
            UsuarioDomain usuarioBuscado = _usuarioRepository.BuscarPorEmailSenha(login.Email, login.Senha);

            if(usuarioBuscado == null)
            {
                return NotFound("Email ou senha inválidos!");
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
                new Claim(ClaimTypes.Role, usuarioBuscado.IdTipoUsuario.ToString())
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(""));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer : "",
                audience : "",
                claims : claims,
                expires : DateTime.Now.AddMinutes(30),
                signingCredentials : creds
            );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            });
        }
        // GET: api/Login
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
