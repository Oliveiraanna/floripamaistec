// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Importação de bibliotecas

// Nome da classe

// Declaração do método

// Declaração de variaveis
int opcao, numero1 = 0, numero2 = 0 ;
float resultado = 0 ;
// Entradas
Console.WriteLine("Escolha uma operação: \n\n" +
    "1 - soma\n2 - subtração\n3 - multipilicação\n4 - divisão\n5 - sair\n\n" +
    "Digite a opção escolhida:  ");

opcao = int.Parse(Console.ReadLine());
    // Processamento
    switch(opcao)
{
    // Bloco de instruções da estrutura condicional
    case 1:
        Console.WriteLine("Operação somar.");
        Console.WriteLine("Digite o número 1: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número 2: ");
        numero2 = int.Parse(Console.ReadLine());
        resultado = numero1 + numero2;
        break;
    case 2:
        Console.WriteLine("Operação subtrair.");
        break;
    case 3:
        Console.WriteLine("Operação multiplicar.");
        break;
    case 4:
        Console.WriteLine("Operação dividir.");
        break;
    case 5:
        Console.WriteLine("Operação sair.");
        break;
        
}
        Console.WriteLine("Resultado: " + resultado);
// Saidas