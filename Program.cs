using DesafioPOO.Models;

//Criei duas funções e deixei os parâmetros abiaxo para serem alterados conforme a vontade do usuário
// Chamando o método de teste para o Smartphone Nokia. Abiaxo
TestarSmartphoneNokia();

// Chamando o método de teste para o Smartphone iPhone. Abiaxo
TestarSmartphoneIphone();

static void TestarSmartphoneNokia()
{
    Console.WriteLine("Testando Smartphone Nokia:");

    // Criar um objeto Nokia
    Smartphone nokia = new Nokia(numero: "+559551583801", modelo: "Moto G TODOS", imei: "355839095185288", memoria: 128);

    // Testar ligação
    Console.WriteLine("Teste de ligação...");
    nokia.Ligar();

    // Testar instalação de aplicativo
    Console.WriteLine("\nTestando instalação de aplicativo:");
    nokia.InstalarAplicativo("mIRC");//Até hoje uso, acredita?

    Console.WriteLine("\nFim do teste para Smartphone Nokia.");
    Console.WriteLine("=======================================\n");
}

static void TestarSmartphoneIphone()
{
    Console.WriteLine("Testando Smartphone iPhone:");

    // Criar um objeto iPhone
    Smartphone iphone = new Iphone(numero: "+556493583801", modelo: "Pega Trouxa", imei: "355839097267068", memoria: 256);

    // Testar recebimento de ligação
    Console.WriteLine("Teste de ligação...");
    iphone.ReceberLigacao();

    // Testar instalação de aplicativo
    Console.WriteLine("\nTestando instalação de aplicativo:");
    iphone.InstalarAplicativo("ICQ"); //O verdadeiro mensageiro

    Console.WriteLine("\nFim do teste para Smartphone iPhone.");
    Console.WriteLine("------------------------------------\n");
}