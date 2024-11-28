namespace FretamentoApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Senha { get; set; }
        public required string TipoUsuario { get; set; } // Admin ou Operador
    }
}