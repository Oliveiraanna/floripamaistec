string[] frutas = new string[15];

// Solicita ao usuário para digitar até 15 frutas
Console.WriteLine("Digite até 15 frutas, uma por linha (pressione Enter duas vezes para encerrar):");

// Loop para ler as frutas digitadas pelo usuário
int i;
for (i = 0; i < 15; i++)
{
    string fruta = Console.ReadLine();

    // Se a linha estiver vazia, encerra o loop
    if (string.IsNullOrEmpty(fruta))
    {
        break;
    }

    frutas[i] = fruta;
}

// Redimensiona o array de frutas para o número de itens digitados pelo usuário
Array.Resize(ref frutas, i);

// Ordena as frutas em ordem alfabética
Array.Sort(frutas);

// Exibe as frutas em ordem alfabética com um ID
Console.WriteLine("Lista de frutas em ordem alfabética:");
for (int j = 0; j < frutas.Length; j++)
{
    Console.WriteLine((j + 1) + ": " + frutas[j]);
}