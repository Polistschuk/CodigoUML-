namespace EncontroRemoto
{
    public abstract class PessoaFisica : Pessoa
    {
        public String? cpf { get; set; }
        public DateTime dataNascimento { get; set; }
    }
}