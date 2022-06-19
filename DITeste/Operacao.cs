namespace DITeste
{
    public class Operacao : IOperacao
    {
       public Guid Id { get; set; }

        public Operacao()
        {
            Id = Guid.NewGuid();
        }
    }

   
}