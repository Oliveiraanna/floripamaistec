// Variáveis para armazenar os números da sequência de Fibonacci
int n;
int x = 1, y = 0, z = 0;

// Lê a quantidade de números da sequência de Fibonacci a serem exibidos
Console.WriteLine("Digite a quantidade de números da sequência de Fibonacci que deseja exibir:");
string number = Console.ReadLine();

// Converte a string para inteiro
n = int.Parse(number);

// Cria a sequência de Fibonacci
for (int i = 0; i < n; i++)
    {
    // A sequência consiste em somar o número anterior (numeroAnterior) com o número atual (numeroAtual)
    // e o resultado será o próximo número (novoNumero)
    z = x + y;
    Console.WriteLine(z);
    y = x;
    x = z;
}

// Aguarda a entrada do usuário antes de fechar a aplicação
Console.ReadLine();
