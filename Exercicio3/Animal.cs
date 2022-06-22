using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public abstract class Animal
    {
        public string nome;
        public double numeroPatas;
        public string cor;
        public string ambiente;
        public double velocidadeMedia;

        string Nome { get; set; }
        double NumeroPatas { get; set; }
        string Cor { get; set; }
        string Ambiente { get; set; }
        double VelocidadeMedia { get; set; }

        public Animal(string nome, double numeroPatas, string cor, string ambiente, double velocidadeMedia)
        {
            this.Nome = nome;
            this.NumeroPatas = numeroPatas;
            this.Cor = cor;
            this.Ambiente = ambiente;
            this.VelocidadeMedia = velocidadeMedia;
        }

        public void ImprimirAnimal()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Número de patas: " + numeroPatas);
            Console.WriteLine("Cor: " + cor);
            Console.WriteLine("Ambiente: " + ambiente);
            Console.WriteLine("Velocidade média: " + velocidadeMedia);
            
        }
    }
}
