namespace EncontroRemoto
{
    public abstract class PessoaJuridica : Pessoa
    {
        public String? cnpj { get; set; }
        public String? razaoSocial { get; set; }
    }
}