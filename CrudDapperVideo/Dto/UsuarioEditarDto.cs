namespace CrudDapperVideo.Dto
{
    public class UsuarioEditarDto
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public string Cargo { get; set; }

        public string Unidade { get; set; }

        public bool Situacao { get; set; } // 1 - Ativo ; 0 - Inativo
    }
}
