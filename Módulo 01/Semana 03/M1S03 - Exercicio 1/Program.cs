using M1S03;
 
    {
        Produto produto1 = new Produto("Calculadora", 1.80, 200);
        Produto produto2 = new Produto();

        Console.WriteLine($"O nome, preço e quantidade do produto 1 é: {produto1.nome}, {produto1.preco}, {produto1.quantidade}.");
        Console.WriteLine($"O nome, preço e quantidade do produto 2 é: {produto2.nome}, {produto2.preco}, {produto2.quantidade}.");

        Console.ReadKey();
    }



