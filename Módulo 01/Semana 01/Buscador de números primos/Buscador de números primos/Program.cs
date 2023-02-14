
    static bool primo(int numero)
    {
        if (numero < 2)
        {
            return false;
        }
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    {
        int[] numeros = new int[10];  // array para armazenar os dez números
    int[] arrayDeNumeros = new int[10];

    // iteração para ler 10 vezes um número no console
    for (int i = 0; i < 10; i++)
    {
        // precisamos somar + 1 por conta que o i inicia em 0
        Console.Write($"Digite o {i + 1}º número: ");

        int num = int.Parse(Console.ReadLine());
        arrayDeNumeros[i] = num;
    }

    // iterador por cada número para verificar se é primo
    for (int i = 0; i < 10; i++)
    {

        // o contador vai marcar quantas vezes ele é divisível por um número menor que ele
        // Inicia-se em 1 porque todo número é divisível por 1
        int contador = 1;

        // Inicia-se em 1 porque se iniciarmos com 0 na divisão vai quebrar, pois o C# não divide um número por 0.
        for (int n = 1; n < arrayDeNumeros[i]; n++)
        {
            if (arrayDeNumeros[i] % n == 0)
            {
                contador = contador + 1;
                // contador++;
            }
        }

        // se o contador der 2 é sinal que ele é divisível somente por 0 e por ele mesmo, portanto, primo.
        if (contador == 2)
        {
            Console.WriteLine($"O número {arrayDeNumeros[i]} é um número primo. Ela está na posição {i} do Array de números.");
        }
    }



    for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());  // lê o número do usuário e armazena no array
        }

        int[] primos = new int[10];  // cria um array de inteiros para armazenar os números primos
        int contador = 0;  // contador para o número de primos encontrados

        for (int i = 0; i < 10; i++)
        {
            if (primo(numeros[i]))
            {
                primos[contador] = numeros[i];
                contador++;
            }
        }

        if (contador == 0)
        {
            Console.WriteLine("Não há números primos na lista.");
        }
        else
        {
            Console.WriteLine("Números primos:");
            for (int i = 0; i < contador; i++)
            {
                int numero = primos[i];
                int posicao = Array.IndexOf(numeros, numero);
                Console.WriteLine($"{numero} se encontra na posição {posicao}");
            }
        }
    }
