using Desafio_4_POO.Documentos.Classes;
using System;

namespace Desafio_4_POO
{
    public class Livro : Produto
    {
        public Livro(string nome, double preco, int quantidade, string autor, string tema, int quantidadePag) : base(nome, preco, quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
            this.Autor = autor;
            this.Tema = tema;
            this.QuantidadePag = quantidadePag;
        }

        public string Autor { get; set; }
        public string Tema { get; set; }
        public int  QuantidadePag { get; set; }
        public double ValorImposto { get; set; }
        public double TotalPrt { get; set; }

        public override void CalculaImposto()
        {
            if (this.Tema != "educativo")
            {
                this.TotalPrt = this.Preco * this.Quantidade;
                this.ValorImposto = this.Preco * 0.10;
                Console.WriteLine($"R$ {this.ValorImposto,8:c} de imposto sobre o livro {this.Nome}");
            }
            else
            {
                this.TotalPrt = this.Preco * this.Quantidade;
                Console.WriteLine("Livro educativo não tem imposto: " + this.Nome);
            }
            
        }

        public override string ToString()
        {
            return $"Título: { this.Nome}, preço: R$ {this.Preco,8:c}, quantidade: {this.Quantidade} em estoque.";
        }
    }
}
