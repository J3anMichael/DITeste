namespace DITeste
{
    public class Endereco : IEndereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Referencia { get; set; }


        public Endereco()
        {
            Rua = "Avenida Sete de Setembro";
            Numero = 3551;
            Referencia = "Apto 104";
        }

    }
}
