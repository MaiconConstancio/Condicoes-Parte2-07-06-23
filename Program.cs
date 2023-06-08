using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TarefaAula06Dia070623
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mesDaViagem;
            int diaDaViagem;
            string turno;
            string confirmação;
            string nome;

            string NovoNome;
            mesDaViagem = 0;
            NovoNome = "";

            string AperteEnter;


            Console.WriteLine("Seja bem-vindo a companhia de MK VooS");
            Console.WriteLine("Viaje no seu ritmo e do seu jeito!");
            Console.WriteLine("E para isso, nós da MK VooS vamos te ajudar!");
            
            Console.WriteLine("\nQual o seu nome?"); //Pulei linha
            nome = Console.ReadLine();

            Console.WriteLine("\n"); //Pulei linha

            Console.WriteLine($"Certo {nome}! Temos passagens disponíveis entre os meses:");
            Console.WriteLine("   08 - Agosto");
            Console.WriteLine("   09 - Setembro");
            Console.WriteLine("   10 - Outubro");

            Console.WriteLine("\nObs: descreva com numeros, exemplo: 05");

            mesDaViagem = Int32.Parse(Console.ReadLine());
            Console.Write("\n"); //Pulei linha         

            if (mesDaViagem == 08)
            {
                 Console.WriteLine("Mês de Agosto, confirmado!");
            }
                else if (mesDaViagem == 09)
                {
                       Console.WriteLine("Mês de Setembro,confirmado!");
                }
                    else if (mesDaViagem == 10)
                    {
                             Console.WriteLine("Mês de Outubro, confirmado!");
                    }

            else
            {
                Console.WriteLine("Mês invalido\n"); //Pulei linha
                Console.WriteLine("-------vamos tentar novamente?-------\n"); //Pulei linha
                Main(null);
                return;
            }


                       //------------------------ bloco que transforma o mês de número em escrita -----------------------
                           if (mesDaViagem == 08)
                           {
                               NovoNome = "AGOSTO";
                           }
                                  else if (mesDaViagem == 09)
                                  {
                                       NovoNome = "SETEMBRO";
                                  }
                                            else if (mesDaViagem == 10)
                                            {
                                               NovoNome = "OUTUBRO";
                                            }
                            else
                            {
                              NovoNome = "ERRO";
                            }

                       //------------------------------------------------------------------------------------------------

            // ------------------------ Mudei de bloco ( Dia ) -----------------------------------------



            Console.WriteLine($"\nPara o mês {NovoNome}, temos disponiveis os dias 6 à 21"); //Pulei linha
            Console.WriteLine("Qual o dia perfeito para sua viagem?");
            diaDaViagem = Int32.Parse(Console.ReadLine());
            Console.Write("\n"); //Pulei linha

            

            if (diaDaViagem <= 5)
            {
                Console.WriteLine("Dia inválido!\n"); //Pulei linha
                Console.WriteLine("-------vamos tentar novamente?-------\n"); //Pulei linha
                Main(null);
                return;
            }
                    else if (diaDaViagem >= 22)
                    {
                    Console.WriteLine("Dia inválido!\n"); //Pulei linha
                    Console.WriteLine("-------vamos tentar novamente?-------\n"); //Pulei linha
                    Main(null);
                    return;
                    }
            else
            {
                Console.WriteLine($"Dia {diaDaViagem}, reservado com sucesso!");
            }

 // ------------------------ Mudei de bloco ( Turno ) -----------------------------------------

            Console.WriteLine("\nAgora que sabemos o dia e o mês, está faltando pouquinho!!"); //Pulei linha
            Console.WriteLine("Só precisamos saber sua preferência.");
            Console.WriteLine("Qual mais te agrada?\n"); //Pulei linha
            Console.WriteLine("   - Manhã");
            Console.WriteLine("   - Tarde");
            Console.WriteLine("   - Noite");
            Console.WriteLine("\nObs: escreva EXATAMENTE como está as opções acima."); 


            turno = Console.ReadLine();
            Console.Write("\n"); //Pulei linha

            if (turno == "Manhã")
            {
                Console.WriteLine("Perfeito! reservamos no período da manhã!");
            }
                else if (turno == "Tarde")
                {
                    Console.WriteLine("Perfeito! reservamos no período da tarde!");
                }
                    else if (turno == "Noite")
                    {
                        Console.WriteLine("Perfeito! reservamos no período da noite!");
                    }
            else
            {
                Console.WriteLine("Turno inválido!\n"); //Pulei linha
                Console.WriteLine("-------vamos tentar novamente?-------\n"); //Pulei linha
                Main(null);
                return;
            }
             
 // ------------------------ Mudei de bloco (Mensagem de confirmação) -----------------------------------------

            Console.WriteLine("\nCompra das passagens realizadas com sucesso!!"); //Pulei linha
            Console.WriteLine("Eu falei que seria rápido, não falei?!!");
            Console.WriteLine("\n\nGostaria de ver o recibo e confirmação de sua compra?"); //Pulei DUPLA linha
            Console.WriteLine("Digite ''Sim'' ou ''Não''");

            confirmação = Console.ReadLine();
            Console.Write("\n"); //Pulei linha

            if (confirmação == "Sim")
            {
                Console.WriteLine("\nÓtimo, vamos lá!!"); //Pulei linha
                Console.WriteLine($"\n\n-----------------------------------------------");//Pulei DUPLA linha
                Console.WriteLine($"Prezado(a) {nome}");
                Console.WriteLine($"Você adquirio uma viagem inesquecível no mês {NovoNome}!");
                Console.WriteLine($"No dia {diaDaViagem}");
                Console.WriteLine($"No período da {turno}");
                Console.WriteLine($"Caso tenha alguma dúvida, temos nosso número de SAC, anote ai!");
                Console.WriteLine($"4002-8922 - Ao atender, é só dizer, ''novo som do Japonês que vai dar playstation 3''");
                Console.WriteLine($"\nEntre em contato sempre que precisar, estamos ansiosos para te ajudar!"); //Pulei linha
                Console.WriteLine($"A equipe MK VooS agradece a preferência!");

                Console.WriteLine("\n -------------- Fim da compra --------------"); //Pulei linha
                Console.WriteLine("\n Aperte a tecla >>> ENTER <<< para encerrar nossos serviços!.");
                AperteEnter = Console.ReadLine();
                return;
            }
                    else if (confirmação == "Não")
                    {
                        Console.WriteLine("Certo! A equipe MK VooS agradece a preferência!");
                        Console.WriteLine("\n -------------- Fim da compra --------------"); //Pulei linha
                        Console.WriteLine("\n Aperte a tecla >>> ENTER <<< para encerrar nossos serviços!.");
                        AperteEnter = Console.ReadLine();
                        return;
                    }
            else
            {
                Console.WriteLine("Desculpe não entendi\n"); //Pulei linha
                Console.WriteLine("-------Vamos tentar novamente?-------\n"); //Pulei linha
                Main(null);
                return;
            }
            Console.ReadLine();

        }
    }
}
