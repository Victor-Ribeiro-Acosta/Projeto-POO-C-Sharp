
using System.ComponentModel;

namespace Models
{
    public abstract class Smartphone
    {
        public string Numero;
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;
        protected int RAM;
        protected int Ano;
        protected decimal Preco;

        public void Ligar()
        {
            Console.WriteLine("Realizando Ligação...");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine($"Chamada recebida do número {Numero}");
        }
        public abstract void InstalarAplicativo(string nomeApp);

        public abstract void EspecificarProduto();
        
    }
}