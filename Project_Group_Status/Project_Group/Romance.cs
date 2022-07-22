using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Group
{
    internal class Romance : IFilmes
    {
        public string Nome;
        public int Ano;
        public string Classificacao;
        public string Tempo;

        public Romance(string Nome, int Ano, string Classificacao, string Tempo)
        {
            this.Nome = Nome;
            this.Ano = Ano;
            this.Classificacao = Classificacao;
            this.Tempo = Tempo;
        }

        public void Exibicao()
        {
            Console.WriteLine($"Nome do filme: {Nome}");
            Console.WriteLine($"Ano de lancamento: {Ano}");
            Console.WriteLine($"Classificacao indicativa: {Classificacao}");
            Console.WriteLine($"Duracao do filme: {Tempo}");
        }
    }
}
