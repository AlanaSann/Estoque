using System;

namespace Mercado
{
    public class Produto //produto                
    {
        public int quantidade { get; set; }
        public string data_cadastro { get; set; }
        public string tipo { get; set; }
        public string descricao_do_material { get; set; }


        public virtual void exibirDadosExpecificos()
        {
            Console.WriteLine("quantidade: ");
            Console.WriteLine(this.quantidade);
            Console.WriteLine("data de cadastro");
            Console.WriteLine(this.data_cadastro);
            Console.WriteLine("descrição do material");
            Console.WriteLine(this.descricao_do_material);
            Console.WriteLine("\n");
        }
    }
}