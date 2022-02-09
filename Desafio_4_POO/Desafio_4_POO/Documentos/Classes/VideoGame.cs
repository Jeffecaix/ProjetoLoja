using System;

namespace Desafio_4_POO.Documentos.Classes
{
    public class VideoGame : Produto
    {
        public VideoGame(string nome, double preco, int quantidade, string marca, string modelo, bool usado) : base(nome, preco, quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Usado = usado;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool Usado { get; set; }
        public double ValorImposto { get; set; }
        public double TotalPrt { get; set; }

        public override void CalculaImposto()
        {
            if (this.Usado)
            {
                this.TotalPrt = this.Preco * this.Quantidade;
                this.ValorImposto = this.Preco * 0.25;
                Console.WriteLine($"Imposto {this.Nome} usado é de R$ {this.ValorImposto,8:c}");
            }
            else
            {
                this.TotalPrt = this.Preco * this.Quantidade;
                this.ValorImposto = this.Preco * 0.45;
                Console.WriteLine($"Imposto {this.Nome} é de R$ {this.ValorImposto,8:c}");
            }

        }

        public override string ToString()
        {
            return $"Vídeo-game: {this.Modelo}, preço: R$ {this.Preco,8:c} , quantidade: {this.Quantidade} em estoque.";
        }
    }
}
