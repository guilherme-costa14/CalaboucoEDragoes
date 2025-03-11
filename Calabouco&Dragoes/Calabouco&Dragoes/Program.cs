using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calabouco_Dragoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "", classe = "", raca = "";
            string resposta = "";
            int vida = 100, armadura = 100, dado_monstro, dado_jogador, dado_bau;
            Random dado = new Random();

            Console.WriteLine("Informe seu nome, aventureiro(a).");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua classe.");
            classe = Console.ReadLine();

            Console.WriteLine("Informe sua raça.");
            raca = Console.ReadLine();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ficha: ");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Classe: " + classe);
            Console.WriteLine("Raça: " + raca);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Deseja entrar na porta a sua esquerda? (S/N)");
            resposta = Console.ReadLine();

            if (resposta == "S")
            {
                Console.WriteLine("Aqui tem um monstro. Você vai enfrentá-lo!!!");

                dado_monstro = dado.Next(1, 6);
                dado_jogador = dado.Next(1, 6);

                Console.WriteLine("Monstro: " + dado_monstro + " - Jogador: " + dado_jogador);

                if (dado_monstro > dado_jogador)
                {
                    Console.WriteLine("Monstro Venceu!!!");
                    vida = vida - 50;
                }
                else
                {
                    Console.WriteLine("Jogador Venceu!!!");
                }

            }
            Console.WriteLine("Sua vida é: " + vida);

            Console.WriteLine("Mais uma sala, você deseja entrar na sala? (S/N)");
            resposta = Console.ReadLine();

            if (resposta == "S")
            {
                Console.WriteLine("Eita, monstro grande, logo ele é monstrão!(Birl)");
                dado_monstro = dado.Next(1, 6);
                dado_jogador = dado.Next(1, 6);

                if (dado_monstro > dado_jogador)
                {
                    Console.WriteLine("Ele te acertou!!!");
                    vida = vida - 60;
                }
                else
                {
                    Console.WriteLine("Você é o bixão mesmo, matou o monstrão");
                }
            }

            Console.WriteLine("Vida " + vida);
            if (vida <= 0)
            {
                Console.WriteLine("Vacilou, você morreu... guenta nada...");
            }
            else
            {
                Console.WriteLine("Continua vivo, merece um abraço... mas não!");
            }

            Console.ReadKey();

            Console.WriteLine("Vocé se deparou com uma porta a direita... Deseja entrar? (S/N)");
            resposta = Console.ReadLine();

            if (resposta == "S")
            {
                Console.WriteLine("A sala que você entrou não tem nem um item de valor");
                Console.WriteLine("Tem uma porta a frente, deseja entrar nela? (S/N)");
                resposta = Console.ReadLine();
                if (resposta == "S")
                {
                    Console.WriteLine("Você encontrou um báu.");
                    dado_bau = dado.Next(1, 6);
                    if (dado_bau == 1)
                    {
                        Console.WriteLine("Você tirou um item comum que vai te ajudar na sua jornada.");
                    }
                    else if (dado_bau == 2)
                    {
                        Console.WriteLine("Você tirou uma arma nova, mas este item também é comum.");
                    }
                    else if (dado_bau == 3)
                    {
                        Console.WriteLine("Que pena, o báu está vazio.");
                    }
                    else if(dado_bau == 4)
                    {
                        Console.WriteLine("Que pena, o báu está vazio.");
                    }
                    else if (dado_bau == 5)
                    {
                        Console.WriteLine("Você tirou um item lendário que vai te ajudar na sua jornada.");
                    }
                    else
                    {
                        Console.WriteLine("Infelizmente você não conseguiu nada que te ajude na sua aventura, siga em frente.");
                    }
                }
            }

            if (resposta == "N")
            {
                Console.WriteLine("Contínue a sua jornada");
            }
            Console.ReadKey();

            Console.WriteLine("Você encontrou o que parece ser uma salão antigo, deseja entrar? (S/N)");
            resposta = Console.ReadLine();
            if (resposta == "S")
            {
                Console.WriteLine("Eita, você se daparou com um monstro... prepare-se para enfrenta-lo");
                dado_monstro = dado.Next(1, 6);
                dado_jogador = dado.Next(1, 6);
                
                if(dado_monstro > dado_jogador)
                {
                    Console.WriteLine("Ele te acertou!!!");
                    vida = vida - 40;
                    Console.WriteLine("Vida " + vida);
                }
                
                if (vida > 0)
                {
                    Console.WriteLine("Falta pouco... de mais um golpe ou fuja pela a sua vida... Fugir? (S/N)");
                    resposta = Console.ReadLine();
                    if(resposta == "S")
                    {
                        Console.WriteLine("Você é um bebê chorão T-T... e abandonou a luta");
                    }

                    if(resposta == "N")
                    {
                        Console.WriteLine("Você é um verdadeiro heroí.");
                        dado_jogador = dado.Next(1, 6);
                        dado_monstro = dado.Next(1, 6);

                        if(dado_monstro > dado_jogador)
                        {
                            Console.WriteLine("Infelizmente a sua bravura não te recompensou... era melhor você ter fugido... FIM DE JOGO.");
                        }
                        else
                        {
                            Console.WriteLine("Você derrotou o monstro... como recompensa da sua coragem você ganhou um item novo.");
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Item: Armadura -  " + armadura);
                            Console.WriteLine("-----------------------------------------");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("A sua aventura chegou ao fim. " + vida);
                }
            }

            Console.ReadKey();
            Console.WriteLine("Contínue a sua jornada, explorando a área.");
            Console.ReadKey();

            Console.WriteLine();
        }
    }
}