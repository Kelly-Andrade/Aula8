namespace Exercicio3
{
    internal class Mamifero : Animal
    {
        private string alimento;

        public string Alimento { get; set; }

        public Mamifero(string nome, double numeroPatas, string cor, string ambiente, double velocidadeMedia, string alimento) 
            : base(nome, numeroPatas, cor, ambiente, velocidadeMedia)
        {
            this.nome = nome;
            this.numeroPatas = numeroPatas;
            this.cor = cor;
            this.ambiente = ambiente;
            this.velocidadeMedia = velocidadeMedia;
            this.Alimento = alimento;

        }

        public void Imprimir()
        {
            Console.WriteLine("\nMAMÍFERO");
            ImprimirAnimal();
            Console.WriteLine("Alimento: " + Alimento);
        }
    }
}
