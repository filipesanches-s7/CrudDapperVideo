namespace CrudDapperVideo.Dto
{
    public class UsuarioCriarDto
    {
        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public string Cargo { get; set; }

        public string Unidade { get; set; }

        public bool Situacao { get; set; } // 1 - Ativo ; 0 - Inativo

        public string Senha { get; set; }


    }

}
