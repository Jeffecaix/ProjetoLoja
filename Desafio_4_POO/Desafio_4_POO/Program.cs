using Desafio_4_POO.Documentos.Classes;
using System;
using System.Collections.Generic;

namespace Desafio_4_POO
{
    class Program
    {
        static void Main(string[] args)
        {

            Livro livro1 = new Livro("Harry Potter", 40, 50, "J. K Rowling", "fantasia", 300);
            Livro livro2 = new Livro("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            Livro livro3 = new Livro("C# POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(livro1);
            livros.Add(livro2);
            livros.Add(livro3);

            List<VideoGame> games_1 = new List<VideoGame>();
            games_1.Add(ps4);
            games_1.Add(ps4Usado);
            games_1.Add(xbox);


            Loja americanas = new Loja("Americanas", "12345678", livros, games_1);

            Console.WriteLine("------------------------------------------------------------------");
            livro1.CalculaImposto();
            livro2.CalculaImposto();
            livro3.CalculaImposto();
            Console.WriteLine("------------------------------------------------------------------");
            ps4.CalculaImposto();
            ps4Usado.CalculaImposto();
            xbox.CalculaImposto();
            Console.WriteLine("------------------------------------------------------------------");            
            americanas.ListaLivros();
            Console.WriteLine("------------------------------------------------------------------");
            americanas.ListaVideoGame();
            Console.WriteLine("------------------------------------------------------------------");
            
            americanas.CalculaPatrimonio(ps4.TotalPrt, ps4Usado.TotalPrt, xbox.TotalPrt, livro1.TotalPrt, livro2.TotalPrt, livro3.TotalPrt);
            
        }
    }
}
