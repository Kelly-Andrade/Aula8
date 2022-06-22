namespace Exercicio2
{
    public class Cliente 
    {   
        public string nomeCliente;
        public double idade;
        public double codigoCliente;
        public string endereco;
        public string telefone;

        string NomeCliente { get; set; }
        double Idade { get; set; }
        double CodigoCliente { get; set; }
        string Endereco { get; set; }
        string Telefone { get; set; }

        public Cliente(/*string nomeCliente, double idade, double codigoCliente, string endereco, string telefone*/)
        {
            this.NomeCliente = nomeCliente;
            this.Idade = idade;
            this.CodigoCliente = codigoCliente;
            this.Endereco = endereco;
            this.Telefone = telefone;
            //CadastrarCliente();
            //ImprimirCliente();
        }

        public void ImprimirCliente()
        {
            Console.WriteLine($@"
Nome do cliente: {NomeCliente}
Idade: {Idade}
Código cliente: {CodigoCliente}
Endereco: {Endereco}
Telefone: {Telefone}");
        }
        
        public void CadastrarCliente()
        {
            Console.WriteLine($"Digite o nome do Cliente: ");
            NomeCliente = Console.ReadLine();
            Console.WriteLine($"Digite a idade: ");
            Idade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Digite o código: ");
            CodigoCliente = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Digite o endereço: ");
            Endereco = Console.ReadLine();
            Console.WriteLine($"Digite o telefone: ");
            Telefone = Console.ReadLine();

        }
    }

   
}
