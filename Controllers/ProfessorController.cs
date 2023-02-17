using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiTcc.Models;
using ApiTcc.Models.Enuns;


namespace ApiTcc.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProfessorController : ControllerBase
    {
        //Modo de criação de objetos de uma só vez na lista
        private static List<Professor> usuarios = new List<Professor>()
        {
            new Professor() { Id = 1, Nome = "Carlos" , Rm = 0001},
            new Professor() { Id = 2, Nome = "Luis" , Rm = 0002},
            new Professor() { Id = 3, Nome = "Aiman" , Rm = 0003},
            new Professor() { Id = 4, Nome = "Gabriel" , Rm = 0004},
            new Professor() { Id = 5, Nome = "Rogerio" , Rm = 0005},
            new Professor() { Id = 6, Nome = "Passa" , Rm = 0006}
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(usuarios);
        }


        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(usuarios.FirstOrDefault(us => us.Id == id));
        }

       /*[HttpPost]
        public IActionResult AddUsuario(Professor novoUsuario)
        {
            usuarios.Add(novoUsuario);
            return Ok(usuarios);
        }*/


            [HttpPut]
            public IActionResult Alterar (Professor AlterarUsuario, List<Professor> usuarios)
        {
                Professor usuarioAlterado = usuarios.Find(user => user.Id == AlterarUsuario.Id); //procurando/indentificando/encontrando o professor atráves do id para que possamos fazer as devidas alterações requisitadas que estão dentro da variavel "AlterarUsuario" passando para a variavel "usuarioAlterado" que criamos para fazer a indentificação do objeto e as alterações
                usuarioAlterado.Id = AlterarUsuario.Id;
                usuarioAlterado.Nome = AlterarUsuario.Nome;
                usuarioAlterado.Rm = AlterarUsuario.Rm;

                return Ok (usuarios);

        }



         /*   [HttpDelete("{id}")]
            public IActionResult DeletarUsuario (int id)
            {
                usuarios.RemoveAll (user => user.Id == id);

                return Ok (usuarios);

            }*/

        }
        }