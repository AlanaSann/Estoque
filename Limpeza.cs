using Mercado;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque
{
    class Limpeza : Produto
    {
        public string inflamavel { get; set; }

        public override void exibirDadosExpecificos()
        {
            base.exibirDadosExpecificos();
            Console.WriteLine("inflamavel");
            Console.WriteLine(this.inflamavel);
        }
    }

    
}
