namespace DesafioPOO.Models
{    // A classe abstrata Smartphone serve como uma base para diferentes modelos de smartphones. Nesse caso, Iphone e Nokia.
    public abstract class Smartphone
    {
        // Propriedades:
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        // Construtor da classe que inicializa os atributos com os valores fornecidos. (acima)
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        // Método que simula a ação de ligar o smartphone, exibindo uma mensagem no console.
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        // Método que simula a ação de receber uma ligação, exibindo uma mensagem no console.
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        // Método abstrato que deve ser implementado por classes derivadas para instalar aplicativos.
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
