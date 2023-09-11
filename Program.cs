using System;
using Verbum_Panis.model_repository;
using Verbum_Panis.Controller;

namespace Verbum_Panis
{
    internal class Program
    {
       
        
        private static ConsoleKeyInfo ConsoleKeyInfo;

        static void Main(string[] args)
        {
                int opcao, id, tipo, NumeroDePg;
                string? nome,autor;
                decimal preco;

            ProdutoController produto = new();

            while (true)
            {


                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("************************************************************************");
                Console.WriteLine("                                                                        ");
                Console.WriteLine("                            Verbum Panis                                ");
                Console.WriteLine("                                                                        ");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("                                                                        ");
                Console.WriteLine("                      1 - Cadastrar Produto                             ");
                Console.WriteLine("                      2 - Listar todos os Produtos                      ");
                Console.WriteLine("                      3 - Consultar produtos por Id                     ");
                Console.WriteLine("                      4 - Atualizar Produto                             ");
                Console.WriteLine("                      5 - Deletar Produto                               ");
                Console.WriteLine("                      6 - Sair                                          ");
                Console.WriteLine("                                                                        ");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("Entre com a opção desejada:                                             ");
                Console.WriteLine("                                                                        ");

                try
                {

                    opcao = Convert.ToInt32(Console.ReadLine());

                }catch (FormatException)
                {
                    Console.WriteLine("Digite uma opção de 1 a 6!");
                    opcao = 0;
                }


                if (opcao == 6)
                {
                    Console.WriteLine("\nA verbum Panis Agradece, Volte Sempre!");
                    sobre();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cadastrar Novo Produto:\n");

                        Console.WriteLine("Digite o Nome do Produto:");
                        nome = Console.ReadLine();

                        Console.WriteLine("Digite o Número de Identificação do Produto:");
                        id =Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o Tipo do Produto:");
                        tipo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o Preço do Produto:");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Digite o Autor do Livro:");
                        autor = (Console.ReadLine());

                        Console.WriteLine("Digite o Número de Páginas do Produto:");
                        NumeroDePg = Convert.ToInt32(Console.ReadLine());

                        produto.Cadastrar(new Livro( id, tipo, nome, preco, autor, NumeroDePg));

                        KeyPress();
                        break;

                    case 2:
                        Console.WriteLine("Listar Todos os Produtos\n");

                        produto.ListarProdutos();

                        KeyPress();
                        break;

                    case 3:
                        Console.WriteLine("Buscar por Número do Produto\n");

                        Console.WriteLine("Digite o Número de Identificação do Produto:");
                        id = Convert.ToInt32(Console.ReadLine());

                        produto.ConsultarProduto(id);

                        KeyPress();
                        break;

                    case 4:
                        Console.WriteLine("Atualizar Produtos\n");

                        Console.WriteLine("Digite o número de Identificação do Produto:");
                        id = Convert.ToInt32(Console.ReadLine());

                        var Produto = produto.BuscarNalista(id);

                        if (Produto is not null)
                        {

                            Console.WriteLine("Digite o Nome do Produto:\n");
                            nome = Console.ReadLine();

                            Console.WriteLine("Digite o Preço do Produto:");
                            preco = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Digite o Autor do Livro:");
                            autor = (Console.ReadLine());

                            Console.WriteLine("Digite o Número de Páginas do Produto:");
                            NumeroDePg = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite o tipo do Produto:");
                            tipo = Convert.ToInt32(Console.ReadLine());

                            produto.Atualizar(new Livro(id, tipo, nome, preco, autor, NumeroDePg));

                        }
                        else
                        {
                            Console.WriteLine($"O Produto de Número {id} não foi encontrado!");
                        }

                        
                        break;

                    case 5:
                        Console.WriteLine("Apagar Produto\n");

                        Console.WriteLine("Digite o Número de Identificação do Produto:\n\n");
                        id = Convert.ToInt32(Console.ReadLine());

                        produto.Deletar(id);

                        KeyPress();
                        break;

                    case 6:
                        Console.WriteLine("Sair\n");

                        KeyPress();
                        break;

                    default:
                        Console.WriteLine("\nOpção Inválida!\n");

                        KeyPress();
                        break;
                }



                static void sobre()
                {
                    Console.WriteLine("\n************************************************************************");
                    Console.WriteLine("Verbum Panis artigos Sacros");
                    Console.WriteLine("Pedro Augusto Pacheco de Souza Santos - pedroaugustopacheco16@gmail.com");
                    Console.WriteLine("github.com/pedro-pacheco16");
                    Console.WriteLine("************************************************************************");

                }
                static void KeyPress()
                {
                    do
                    {
                        Console.Write("\nPressione Enter para Continuar...\"");
                        ConsoleKeyInfo = Console.ReadKey();
                    } while (ConsoleKeyInfo.Key != ConsoleKey.Enter);
                }

            }
        }
    }
}

    
