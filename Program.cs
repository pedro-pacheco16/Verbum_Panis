using System;

namespace Verbum_Panis
{
    internal class Program
    {
       
        
        private static ConsoleKeyInfo ConsoleKeyInfo;

        static void Main(string[] args)
        {
                int opcao, id, tipo;
                string? nome;
                decimal preco;
                 


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
                Console.WriteLine("                      1 - Cadastrar Produto                                 ");
                Console.WriteLine("                      2 - Listar todos os Produtos                      ");
                Console.WriteLine("                      3 - Consultar produtos por Id                     ");
                Console.WriteLine("                      4 - Atualizar Produto                             ");
                Console.WriteLine("                      5 - Deletar Produto                               ");
                Console.WriteLine("                      6 - Sair                                          ");
                Console.WriteLine("                                                                        ");
                Console.WriteLine("************************************************************************");
                Console.WriteLine("Entre com a opção desejada:                                             ");
                Console.WriteLine("                                                                        ");


                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 6)
                {
                    Console.WriteLine("\nA verbum Panis Agradece, Volte Sempre!");
                    sobre();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cadastrar novo Produto:\n\n");

                        Console.WriteLine("Digite o nome do produto:\n\n");
                        nome = Console.ReadLine();

                        Console.WriteLine("Digite o número de identificação do produto:\n\n");
                        id =Convert.ToInt32(Console.ReadLine());

                        KeyPress();
                        break;

                    case 2:
                        Console.WriteLine("Listar todos os produtos\n\n");



                        KeyPress();
                        break;

                    case 3:
                        Console.WriteLine("Buscar por Numero do Produto\n\n");

                        Console.WriteLine("Digite o número de identificação do produto:\n\n");
                        id = Convert.ToInt32(Console.ReadLine());

                        KeyPress();
                        break;

                    case 4:
                        Console.WriteLine("Atualizar Produtos\n\n");

                        Console.WriteLine("Digite o número de identificação do produto:\n\n");
                        id = Convert.ToInt32(Console.ReadLine());

                        KeyPress();
                        break;

                    case 5:
                        Console.WriteLine("Apagar Produto\n\n");

                        Console.WriteLine("Digite o número de identificação do produto:\n\n");
                        id = Convert.ToInt32(Console.ReadLine());

                        KeyPress();
                        break;

                    case 6:
                        Console.WriteLine("Sair\n\n");

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

    
