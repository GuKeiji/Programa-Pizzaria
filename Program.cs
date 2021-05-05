using System;

namespace PizzariaChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "";
            string escolherItem = "";
            string escolherPizzaTipo = "";
            string escolherSaborDoce = "";
            string escolherSaborSalgado = "";
            string texto = "";
            float valor = 0;
            float valorDesconto = 0;
            float valorDescontado = 0;
            // bool check = false;
            DateTime horario = DateTime.Now;
            // Console.WriteLine(horario.Hour);
            Console.WriteLine("\nSeja Bem-Vindo á pizzaria Parmeggio! Para abrir o Menu digite: menu");
            menu = Console.ReadLine().ToLower();
            while (menu == "menu")
            {
                Console.WriteLine("\n------Menu------\n");
                Console.WriteLine("\nPizza - Esfirra\n");
                Console.WriteLine("O que você deseja consultar?");
                escolherItem = Console.ReadLine().ToLower();

                if (escolherItem == "pizza")
                {
                    Console.WriteLine("\nPizzas Doces - Pizzas Salgadas\n");
                    Console.WriteLine("Escolha uma das opções");
                    escolherPizzaTipo = Console.ReadLine().ToLower();

                    while (escolherPizzaTipo == "pizzas doces")
                    {
                        Console.WriteLine("\nSabores:\nBrigadeiro\nRomeu e Julieta\nDoçinho de Pessego");
                        Console.WriteLine("\nEscolha uma das opções" + texto);
                        escolherSaborDoce = Console.ReadLine().ToLower();

                        if (horario.Hour < 19)
                        {
                            if (escolherSaborDoce == "brigadeiro")
                            {
                                valor = 30;
                                valorDesconto = valor * 20 / 100;
                                valorDescontado = valor - valorDesconto;
                                Console.Write("\nBrigadeiro R$" + valorDescontado + "\nRecheada com um delicioso chocolate feito de cacau,\ncom lascas de chocolate também feito de cacau, coberto com queijo do tipo Parmeggio");
                                escolherPizzaTipo = "";
                            }
                            else if (escolherSaborDoce == "romeu e julieta")
                            {
                                valor = 35;
                                valorDesconto = valor * 20 / 100;
                                valorDescontado = valor - valorDesconto;
                                Console.Write("\nRomeu e Julieta R$" + valorDescontado + "\nRecheada com a maravilhosa goiabada,\ncombinada com o famoso queijo do tipo Parmeggio");
                                escolherPizzaTipo = "";
                            }
                            else if (escolherSaborDoce == "doçinho de pessego")
                            {
                                valor = 38;
                                valorDesconto = valor * 20 / 100;
                                valorDescontado = valor - valorDesconto;
                                Console.Write("\nDoçinho de Pessego R$" + valorDescontado + "\nRecheada com o melhor Doçinho de pessego que você já viu,\ncom lâminas de pêssego em caldas, coberto com o nosso queijo especial do tipo Parmeggio");
                                escolherPizzaTipo = "";
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\nSabor inválido\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                texto = " novamente";
                            }

                        }
                        else
                        {

                            if (escolherSaborDoce == "brigadeiro")
                            {
                                valor = 30;
                                Console.Write("\nBrigadeiro R$" + valor + "\nRecheada com um delicioso chocolate feito de cacau,\ncom lascas de chocolate também feito de cacau, coberto com queijo do tipo Parmeggio");
                                escolherPizzaTipo = "";
                            }
                            else if (escolherSaborDoce == "romeu e julieta")
                            {
                                valor = 35;
                                Console.Write("\nRomeu e Julieta R$" + valor + "\nRecheada com a maravilhosa goiabada,\ncombinada com o famoso queijo do tipo Parmeggio");
                                escolherPizzaTipo = "";
                            }
                            else if (escolherSaborDoce == "doçinho de pessego")
                            {
                                valor = 38;
                                Console.Write("\nDoçinho de Pessego R$" + valor + "\nRecheada com o melhor Doçinho de pessego que você já viu,\ncom lâminas de pêssego em caldas, coberto com o nosso queijo especial do tipo Parmeggio");
                                escolherPizzaTipo = "";
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\nSabor inválido\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                texto = " novamente";
                            }
                        }

                    }

                    while (escolherPizzaTipo == "pizzas salgadas")
                    {
                        Console.WriteLine("\nSabores:\nBuon Parmeggio\nDelicinha\nMartiello");
                        Console.WriteLine("\nEscolha uma das opções" + texto);
                        escolherSaborSalgado = Console.ReadLine().ToLower();
                        if (horario.Hour < 19)
                        {
                            if (escolherSaborSalgado == "buon parmeggio")
                            {
                                valor = 40;
                                valorDesconto = valor * 20 / 100;
                                valorDescontado = valor - valorDesconto;
                                Console.Write("\nBuon Parmeggio R$" + valorDescontado + "\nRecheada com um delicioso queijo do tipo Parmeggio\ncom um agradável sabor de tomates");
                                escolherPizzaTipo = "";
                            }
                            else if (escolherSaborSalgado == "delicinha")
                            {
                                valor = 45;
                                valorDesconto = valor * 20 / 100;
                                valorDescontado = valor - valorDesconto;
                                Console.Write("\nDelicinha R$" + valorDescontado + "\nRecheada com uma deliciosa combinação de frango e catupiry,\ncoberta com o famoso queijo do tipo Parmeggio");
                                escolherPizzaTipo = "";
                            }
                            else if (escolherSaborSalgado == "martiello")
                            {
                                valor = 48;
                                valorDesconto = valor * 20 / 100;
                                valorDescontado = valor - valorDesconto;
                                Console.Write("\nMartiello R$" + valorDescontado + "\nRecheada com mussarela de melhor qualidade,\ncom lâminas de calabresa cortada à mão, coberto com o nosso queijo especial do tipo Parmeggio");
                                escolherPizzaTipo = "";
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\nSabor inválido\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                texto = " novamente";
                            }

                        }
                        else
                        {

                            if (escolherSaborSalgado == "buon parmeggio")
                            {
                                valor = 40;
                                Console.Write("\nBuon Parmeggio R$" + valor + "\nRecheada com um delicioso queijo do tipo Parmeggio\ncom um agradável sabor de tomates");
                                escolherPizzaTipo = "";
                            }
                            else if (escolherSaborSalgado == "delicinha")
                            {
                                valor = 45;
                                Console.Write("\nDelicinha R$" + valor + "\nRecheada com uma deliciosa combinação de frango e catupiry,\ncoberta com o famoso queijo do tipo Parmeggio");
                                escolherPizzaTipo = "";
                            }
                            else if (escolherSaborSalgado == "martiello")
                            {
                                valor = 48;
                                Console.Write("\nMartiello R$" + valor + "\nRecheada com mussarela de melhor qualidade,\ncom lâminas de calabresa cortada à mão, coberto com o nosso queijo especial do tipo Parmeggio");
                                escolherPizzaTipo = "";
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\nSabor inválido\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                texto = " novamente";
                            }

                        }
                    }


                }










            }
        }
    }
}
