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
        
        public ItemController(DataContext context)
        {
            _context = context;
        }

       [HttpGet]

       public async Task <IActionResult> Get ()
       {
            try
            {
                List<Item> lista = await _context.Itens.ToListAsync();
                return Ok (lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
       }
    }
}