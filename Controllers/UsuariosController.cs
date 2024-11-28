using FretamentoApi.Data;
using FretamentoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FretamentoApi.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly FretamentoDbContext _context;
        public UsuariosController(FretamentoDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUsuarioById), new { id = usuario.Id }, usuario);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsuarioById(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }
    }
}
