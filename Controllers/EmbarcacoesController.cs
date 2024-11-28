using FretamentoApi.Data;
using FretamentoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FretamentoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmbarcacoesController : ControllerBase
    {
        private readonly FretamentoDbContext _context;

        public EmbarcacoesController(FretamentoDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmbarcacao(Embarcacao embarcacao)
        {
            _context.Embarcacoes.Add(embarcacao);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEmbarcacaoById), new { id = embarcacao.Id }, embarcacao);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmbarcacaoById(int id)
        {
            var embarcacao = await _context.Embarcacoes.FindAsync(id);
            if (embarcacao == null) return NotFound();
            return Ok(embarcacao);
        }
    }
}
