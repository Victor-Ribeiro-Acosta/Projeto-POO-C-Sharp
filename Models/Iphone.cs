using Models;

namespace Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string ParIMEI, int memoria, int ram, int ano, decimal preco)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = ParIMEI;
            Memoria = memoria;
            RAM = ram;
            Ano = ano;
            Preco = preco;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no {Modelo}.");
        }

        public override void EspecificarProduto()
        {
            string mensagem =
            "Marca: Ipone\n"+
            $"Modelo: {Modelo}\n"+
            $"Número de série: {IMEI}\n"+
            $"Memória: {Memoria}\n"+
            $"RAM: {RAM}\n"+
            $"Ano: {Ano}\n"+
            $"Preço: {Preco}";

            Console.WriteLine(mensagem);
        }
    }
}