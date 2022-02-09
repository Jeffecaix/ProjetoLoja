using Desafio_4_POO.Documentos.Interfaces;

namespace Desafio_4_POO.Documentos.Classes
{
    public abstract class Produto : IImposto
    {
        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public abstract void CalculaImposto();
        
    }
}
