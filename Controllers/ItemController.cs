using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTcc.Data;
using ApiTcc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiTcc.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class ItemController : ControllerBase
    {
        private readonly DataContext _context;
        
        public ItemController(DataContext dataContext)
        {
            _context = dataContext;
        }

        [HttpPost]
        public async Task<IActionResult> Add(Item novoItem)
        {
            try{
                await _context.Itens.AddAsync(novoItem);
                await _context.SaveChangesAsync();

                return Ok(novoItem.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Item novoItem)
        {
            try{
                _context.Itens.Update(novoItem);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                 return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try{
             
               List<Item> lista = await _context.Itens.ToListAsync();
               return Ok(lista);
            }
            catch (Exception ex)
            {
                 return BadRequest(ex.Message);
            }
        }
       
    }
}