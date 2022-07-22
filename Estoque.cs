using Estoque;
using Gremlin.Net.Process.Traversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado
{
    public class Estoque
    {
        public List<Produto> ListProduto1 = new List<Produto>(); //criacao do metodo




        public void cadastro() //Função de cadastro
        {

            //escolhe a opção de produto
            Console.WriteLine("TIPO DE PRODUTOS: \n(1)BEBIDAS \n(2)ALIMETOS \n(3)LIMPEZA");
            int t = int.Parse(Console.ReadLine());

            switch (t)
            {
                case 1: //instanciar o objeto bebida
                    Bebida b = new Bebida();

                    Console.WriteLine("Quantidade: ");
                    b.quantidade = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Data de Cadastro: ");
                    b.data_cadastro = Console.ReadLine();

                    Console.WriteLine("Descricao do Material: ");
                    b.descricao_do_material = Console.ReadLine();

                    //booleana para saber se a bebida é acoolica
                    Console.WriteLine("Bebida alcoolica:");
                    bool boolean = Convert.ToBoolean(Console.ReadLine());
                    if (boolean == true)
                    {
                        b.alcool = "tem alcool";
                        Console.WriteLine(b.alcool);
                    }
                    else
                    {
                        b.alcool = "nao tem alcool";
                        Console.WriteLine(b.alcool);
                    }
                    ListProduto1.Add(b);//polimorfismo
                    break;

                case 2:
                    Alimento a = new Alimento();


                    Console.WriteLine("Quantidade: ");
                    a.quantidade = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Data de Cadastro: ");
                    a.data_cadastro = Console.ReadLine();

                    Console.WriteLine("Descricao do Material: ");
                    a.descricao_do_material = Console.ReadLine();
                    Console.WriteLine("Aliemento perecivel?:");
                    //boleano para saber se o alimento é perecivel
                    bool perec = Convert.ToBoolean(Console.ReadLine());
                    if (perec == true)
                    {
                        a.perecivel = "perecivel";
                        Console.WriteLine(a.perecivel);
                    }
                    else
                    {
                        a.perecivel = "nao perecivel";
                        Console.WriteLine(a.perecivel);
                    }
                    ListProduto1.Add(a); //polimorfismo
                    break;

                case 3:
                    Limpeza l = new Limpeza();
             
                    Console.WriteLine("Quantidade: ");
                    l.quantidade = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Data de Cadastro: ");
                    l.data_cadastro = Console.ReadLine();

                    Console.WriteLine("Descricao do Material: ");
                    l.descricao_do_material = Console.ReadLine();

                    Console.WriteLine("inflamavel?:");
                    bool infl = Convert.ToBoolean(Console.ReadLine());
                    if (infl == true)
                    {
                        l.inflamavel = "sim";
                        Console.WriteLine(l.inflamavel);
                    }
                    else
                    {
                        l.inflamavel = "nao";
                        Console.WriteLine(l.inflamavel);
                    }
                    ListProduto1.Add(l);//polimorfismo
                    break;

                default:
                    break;



            }
             

             
        }

        public void consulta()
        {
    
            Console.WriteLine("Lista de Produtos: ");
            foreach (Produto produtos in ListProduto1) //mostra a lista do Estoque
            {
                produtos.exibirDadosExpecificos();
            }
        }


    } }

