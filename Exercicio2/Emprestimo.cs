using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Emprestimo : Cliente
    {
        public double codigoJogo;
        public string dataLocacao;
        public string dataDevolucao;
        public double valorLocacao;

        double CodigoJogo { get; set; }
        string DataLocacao { get; set; }
        string DataDevolucao { get; set; }   
        double ValorLocacao { get; set; }
        

        public Emprestimo()
        {
            this.CodigoJogo = codigoJogo;
            this.DataLocacao = dataLocacao;
            this.DataDevolucao = dataDevolucao;
            this.ValorLocacao = valorLocacao;
            CadastrarCliente();
        }

        
        
        
        public void RenovarEmprestimo()
        {

        }
    }
}
