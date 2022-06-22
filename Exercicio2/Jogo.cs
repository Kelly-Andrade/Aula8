using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Jogo
    {
        private string nome;
        public double classificacaoEtaria;
        public double codigoJogo;
        public double anoLancamento;
        public bool emprestado;

        string Nome {get; set;}
        double ClassificacaoEtaria { get; set;}
        double CodigoJogo { get; set;}
        double AnoLancamento { get; set;}
        bool Emprestado { get; set; }

        public Jogo(string nome, double classificacaoEtaria, double codigoJogo, double anoLancamento, bool emprestado) 
        {
            this.Nome = nome;
            this.ClassificacaoEtaria = classificacaoEtaria;
            this.CodigoJogo = codigoJogo;
            this.AnoLancamento = anoLancamento;
            this.Emprestado = emprestado;
            ImprimirJogo();            
        }

        public void ImprimirJogo()
        {
            Console.WriteLine($@"Nome do Jogo: {Nome}
Classificação etária: {ClassificacaoEtaria}
Codigo: {CodigoJogo}
Ano de lançamento: {AnoLancamento}
Emprestado: {Emprestado}");
            Devolver();
        }

        //public void Locar()
        //{
        //    if (Emprestado == false)
        //    {
        //        Console.WriteLine("1-Locar\n2-Sair");
        //        int locacao = Convert.ToInt16(Console.ReadLine());
        //        if (locacao == 1)
        //        {
        //            Emprestado = true;
        //            Console.WriteLine("Jogo locado com sucesso!");
        //        }
        //        else
        //        {

        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Você não pode locar este jogo pois ele não está disponível");
        //    }
        //}

        public void Devolver()
        {
            switch (Emprestado)
            {
                case false:
                    Emprestado = true;
                    Console.WriteLine("Jogo devolvido");
                    return;
                default:
                    Console.WriteLine("Jogo emprestado");
                    return;
                
            }
            //if(Emprestado == true)
            //{
            //    Console.WriteLine("df");
            //    Emprestado = false;
            //}
            //else
            //{
            //    Console.WriteLine("df");
            //}
        }

    }
}
