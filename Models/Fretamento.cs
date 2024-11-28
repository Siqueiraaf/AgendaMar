using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FretamentoApi.Models
{
    public class Fretamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Horario { get; set; }
        public int QuantidadePessoas { get; set; }
        public decimal Preco { get; set; }
        public int EmbarcacaoId { get; set; }
        public required Embarcacao Embarcacao { get; set; }
    }
}