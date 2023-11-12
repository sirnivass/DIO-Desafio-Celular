namespace DesafioPOO.Models
{    // Essa classe representa um modelo específico de smartphone e herda da classe base Smartphone.
    public class Nokia : Smartphone
    {
        // Construtor da classe Iphone que chama o construtor da classe base (Smartphone).
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        // O construtor inicializa os atributos herdados da classe base(Smartphone).
        }

        // Simula a instalação de um aplicativo...
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo....\n{0} Instalado com Sucesso!", nomeApp);
        }
    }
}
