using ApiTcc.Data;
using ApiTcc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiTcc.Controllers
{

     [ApiController]
     [Route("[Controller]")]
    public class AlmoxarifeController : ControllerBase
    {
       
         //Declaração do atributo
        private readonly DataContext _context;

        public AlmoxarifeController(DataContext context) //construtor para inicializar o atributo "_context" que rebera os dados via parametro
        {
            //Inicialização do atributo a partit de um parametro
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarItem (Item ItemAdicionado)
        {
            try
            {
                List<Item> lista = await _context.Itens.ToListAsync();
                await _context.Itens.AddAsync(ItemAdicionado);
                return Ok (lista);
                
            }

            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }
    }
}