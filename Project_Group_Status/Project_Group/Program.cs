using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_Group
{
    internal class Program
    {
        
        enum Menu {Comedia = 1, Romance, Acao, Terror, Creditos, Sair = 9}
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo - ChinelaFlix - ");
            Console.WriteLine("(Pressione Enter para continuar)");
            Console.ReadKey();
            Console.Clear();

            bool Sair = true;
            while (Sair == true)
            {
                Console.WriteLine("Chinela Flix - Opções");
                Console.WriteLine("Digite o numero correspondente ao Genero:");
                Console.WriteLine("");
                Console.WriteLine(" 1 - Comédia\n 2 - Romance\n 3 - Ação\n 4 - Terror\n 5 - Créditos\n\n\n 9 - Sair");
                Console.WriteLine("");
                int opcao = int.Parse(Console.ReadLine());
                Menu menu = (Menu)opcao;
                switch (menu)
                {
                    case Menu.Comedia:
                        Comedia();
                        break;
                    case Menu.Romance:
                        Romance();
                        break;
                    case Menu.Acao:
                        Acao();
                        break;
                    case Menu.Terror:
                        Terror();
                        break;
                    case Menu.Creditos:
                        Creditos();
                        break;
                    case Menu.Sair:
                        Sair = false;
                        break;

                }
                Console.Clear();
                            
            }
            
        }
        static void Comedia()
        {
            List<IFilmes> comedia = new List<IFilmes>();
            comedia.Add(new Comedia("A Hora do Rush", 1998, "Livre", "1h 38min"));
            comedia.Add(new Comedia("O pequenino", 2006, "Livre", "1h 38min"));
                        
            Console.Clear();
            Console.WriteLine("Lista de Comédia");
            foreach (IFilmes come in comedia)
            {
                Console.WriteLine("");
                come.Exibicao();

            }
            Console.WriteLine("");
            Console.WriteLine("(Pressione Enter para voltar)");

            Console.ReadLine();

        }
        static void Romance()
        {
            List<IFilmes> romance = new List<IFilmes>();
            romance.Add(new Romance("Diário de uma Paixão", 2004, "Livre", "2h 1min"));
            romance.Add(new Romance("Como Eu era Antes de Você", 2016, "Livre", "1h 50min"));

            Console.Clear();
            Console.WriteLine("Lista de Romance");
            foreach (IFilmes rome in romance)
            {
                Console.WriteLine("");
                rome.Exibicao();

            }
            Console.WriteLine("");
            Console.WriteLine("(Pressione Enter para voltar)");

            Console.ReadLine();

        }
        static void Acao()
        {
            List<IFilmes> acao = new List<IFilmes>();
            acao.Add(new Acao("O Exterminador do Futuro", 1991, "14+", "1h 47min"));
            acao.Add(new Acao("Adrenalina", 2006, "18+", "1h 44min"));

            Console.Clear();
            Console.WriteLine("Lista de Ação");
            foreach (IFilmes aca in acao)
            {
                Console.WriteLine("");
                aca.Exibicao();

            }
            Console.WriteLine("");
            Console.WriteLine("(Pressione Enter para voltar)");

            Console.ReadLine();

        }
        static void Terror()
        {
            List<IFilmes> terror = new List<IFilmes>();
            terror.Add(new Terror("Chucky", 1998, "+18", "1h 29min"));
            terror.Add(new Terror("Nem Tudo São Flores", 2022, "+18", "3 meses"));

            Console.Clear();
            Console.WriteLine("Lista de Terror");
            foreach (IFilmes terr in terror)
            {
                Console.WriteLine("");
                terr.Exibicao();

            }
            Console.WriteLine("");
            Console.WriteLine("(Pressione Enter para voltar)");

            Console.ReadLine();

        }
        static void Creditos()
        {
            Console.Clear();
            Console.WriteLine("Deseja ver os Créditos");
            Console.WriteLine("Digite Sim ou Não");
            Console.WriteLine("");

            string opcao2 = Console.ReadLine();
            Console.Clear();
            while (true)
            {
                if (opcao2 == "Sim")
                {
                    Console.WriteLine("Programa feito pela turma .NET 2 Generation");
                    Console.WriteLine("");
                    Console.WriteLine("Beatriz Gomes Trindade\nFabio Iki\nIsrael Felipe\nLucas Fernandes\nMatheus Carnizella\nRaul Andres\nSamira Ixoobecan");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                if (opcao2 == "sim")
                {
                    Console.WriteLine("Programa feito pela turma .NET 2 Generation");
                    Console.WriteLine("");
                    Console.WriteLine("Beatriz Gomes Trindade\nFabio Iki\nIsrael Felipe\nLucas Fernandes\nMatheus Carnizella\nRaul Andres\nSamira Ixoobecan");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if (opcao2 == "Nao")
                {
                    Console.WriteLine("Ingrato :(");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if (opcao2 == "nao")
                {
                    Console.WriteLine("Ingrato :(");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if (opcao2 == "não")
                {
                    Console.WriteLine("Ingrato :(");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if (opcao2 == "Não")
                {
                    Console.WriteLine("Ingrato :(");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else
                {
                    break;
                }
                
            }



            
        }
    }
}
