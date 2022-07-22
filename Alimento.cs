
using Mercado;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque
{
    class Alimento:Produto
    {
        public string perecivel { get; set; }
        public override void exibirDadosExpecificos()
        {
            base.exibirDadosExpecificos();
            Console.WriteLine(this.perecivel);
        }

    }
}
