using CzBooks_WebApi.Domains;
using CzBooks_WebApi.Interfaces;
using CzBooks_WebApi.Repositories;
using CzBooks_WebApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CzBooks_WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {

            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Faz a autenticação do usuário
        /// </summary>
        /// <param name="login">objeto com os dados de e-mail e senha</param>
        /// <returns>Um status code e, em caso de sucesso, os dados do usuário buscado</returns>
        [HttpPost("Login")]
        public IActionResult Post(LoginViewModel login)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.Login(login.Email, login.Senha);

                if (usuarioBuscado == null)
                {
                    return NotFound("E-mail ou senha inválidos!");
                }

                var claims = new[]
 {
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role, usuarioBuscado.IdTipoUsuario.ToString()),
                    new Claim("role", usuarioBuscado.IdTipoUsuario.ToString()),

                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("CzBooks-chave-autenticacao"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "CzBooks.WebApi",              // emissor do token
                    audience: "CzBooks.WebApi",            // destinatário do token
                    claims: claims,                        // dados definidos acima
                    expires: DateTime.Now.AddMinutes(30),  // tempo de expiração
                    signingCredentials: creds              // credenciais do token
                );
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
