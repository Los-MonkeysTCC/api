using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTcc.Models.Enuns;

namespace ApiTcc.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public ItemEnum Status { get; set; }
    }
}