using Mercado;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque
{
    class Bebida:Produto
    {
        public string alcool { get; set; }
        public override void exibirDadosExpecificos() //exibe o alcoolico
        {
            base.exibirDadosExpecificos();
            Console.WriteLine("alcoolico:");
            Console.WriteLine(this.alcool);
        
        }
    }
}
