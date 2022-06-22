namespace Exercicio3
{
    public class Peixe : Animal
    {
        
        private string caracteristica;

        public string Caracteristica { get; set; }

        public Peixe(string nome, double numeroPatas, string cor, string ambiente, double velocidadeMedia, string caracteristica)
            : base(nome, numeroPatas, cor, ambiente, velocidadeMedia)
        {
            this.nome = nome;
            this.numeroPatas = numeroPatas;
            this.cor = cor;
            this.ambiente = ambiente;
            this.velocidadeMedia = velocidadeMedia;
            this.Caracteristica = caracteristica;
            
        }

        public void Imprimir()
        {
            Console.WriteLine("\nPEIXE");
            ImprimirAnimal();
            Console.WriteLine("Característica: " + Caracteristica);
        }
    }
}
