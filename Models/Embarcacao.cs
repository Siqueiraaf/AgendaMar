using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FretamentoApi.Models
{
    public class Embarcacao
    {
         public int Id { get; set; }
        public required string Nome { get; set; }
        public int Capacidade { get; set; }
        public required string Status { get; set; } // Disponível ou Indisponível
    }
}