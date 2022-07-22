using System;
using System.Collections.Generic;
using System.Linq;

namespace Mercado
{
    class Program
    {
        private static object solicitacao;

        public static object Listobejetos_produto { get; private set; }
        public static string ListProdutos { get; private set; }

        static void Main(string[] args)
        {
           
            int opcao = -1;
            Estoque estoque = new Estoque(); //parte do metodo do Estoque fora,para que funcione nas opcoes 1,2,3
            while (opcao != 0)
            {
                int i;
                Console.WriteLine("****************MERCADO************");
                Console.WriteLine("\n(1) CADASTRO \n(2) CONSULTA \n(3) SOLICITACAO DE ITEM \nDIGITE QUALQUER TECLA PARA SAIR");
                i = int.Parse(Console.ReadLine());
            switch (i)
            {   
                    case 1:
                        
                        estoque.cadastro(); //chama o metodo
                 
                        
                        break;
                    case 2:
                        estoque.consulta();
                        break;

                    case 3:
                                    //solicitacão de item
                        int c;
                        Console.WriteLine("Qual item deseja solicitar pela descrição do material:");
                        string item = (Console.ReadLine());
                     
                        foreach (Produto produtos in estoque.ListProduto1)    
                        {
                            if (item == produtos.descricao_do_material)
                            {
                                Console.WriteLine("item encontrado");
                            }
                            else
                            {
                                Console.WriteLine("item nao encontrado");
                            }

                        }

                        break;
                        }
                            
                          

                        }



                }
            }
        }


