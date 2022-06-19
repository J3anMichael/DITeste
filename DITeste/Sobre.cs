namespace DITeste
{
    public class Sobre : ISobre
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }

        public Sobre()
        {
            Nome = "Jean Michael";
            Idade = 25;
            Cidade = "Curitiba";
        }
    }
}
