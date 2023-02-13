using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTcc.Models.Enuns;

namespace ApiTcc.Models
{
    public class Cadastro
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public int Rm { get; set; }

        public int Senha { get; set; }

        public PerfilEnum Perfil{ get; set; }
    }
}