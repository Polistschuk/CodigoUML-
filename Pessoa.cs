namespace EncontroRemoto
{
    public abstract class Pessoa
    {
        public String? nome { get; set; }
        public String? endereco { get; set; }
        public bool enderecoComercial { get; set; }

        public abstract void PagarImposto(float salario);

    }
}