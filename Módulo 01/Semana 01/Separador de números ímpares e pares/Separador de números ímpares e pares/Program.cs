       
        List<int> numerosPares = new List<int>();
        List<int> numerosImpares = new List<int>();

        Console.WriteLine("Digite dez números inteiros:");
        for (int i = 0; i < 10; i++)
        {
            int numero = int.Parse(Console.ReadLine());
    
    // verifica se o número é ímpar ou par

    {
        if (numero % 2 == 0)
            {
                numerosPares.Add(numero);
            }
            else
            {
                numerosImpares.Add(numero);
            }
        }
    // coloca os números em ordem crescente

        numerosPares.Sort();
        numerosImpares.Sort();
    // o método Sum() faz a soma dos números de uma lista

        int somaPares = numerosPares.Sum();
        int somaImpares = numerosImpares.Sum();

        Console.WriteLine($"A lista de números pares possui {numerosPares.Count} números e a soma deles é igual a {somaPares}");
        Console.WriteLine($"A lista de números ímpares possui {numerosImpares.Count} números e a soma deles é igual a {somaImpares}");
    