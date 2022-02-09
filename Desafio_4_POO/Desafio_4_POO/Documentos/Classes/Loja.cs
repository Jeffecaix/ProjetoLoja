using System;
using System.Collections.Generic;

namespace Desafio_4_POO.Documentos.Classes
{
    public class Loja
    {
        
        public Loja(string nome, string cnpj, List<Livro>livros, List<VideoGame>games)
        {
            this.Nome = nome;
            this.CNPJ = cnpj;
            this.livros = livros;
            this.games = games;           

        }

        public string Nome { get; set; }
        public string CNPJ { get; set; }

        List<Livro> livros = new List<Livro>();
        List<VideoGame> games = new List<VideoGame>();

        public void ListaLivros()
        {
            if(livros.Count == 0)
            {
                Console.WriteLine("A loja não tem livros no seu estoque.");
            }
            else
            {
                Console.WriteLine("A loja Americanas possui estes livros para venda:");
                foreach (var item in livros)
                {
                    Console.WriteLine(item);
                }
            }            
        }

        public void ListaVideoGame()
        {
            if (games.Count == 0)
            {
                Console.WriteLine("A loja não tem video-games no seu estoque.");
            }
            else
            {
                Console.WriteLine("A loja Americanas possui estes vídeo-games para venda:");
                foreach (var item in games)
                {                    
                    Console.WriteLine(item);
                }
            }
        }
        // Dar continuidade
        public void CalculaPatrimonio(double entrada_1 = 0, double entrada_2 = 0, double entrada_3 = 0, double entrada_4 = 0, double entrada_5 = 0, double entrada_6 = 0)
        {
            double somaPatrimonio = entrada_1 + entrada_2 + entrada_3 + entrada_4 + entrada_5 + entrada_6;
            Console.WriteLine($"O patrimonio da loja: {this.Nome} é de R$ {somaPatrimonio,8:c}.");
        }


    }
}
