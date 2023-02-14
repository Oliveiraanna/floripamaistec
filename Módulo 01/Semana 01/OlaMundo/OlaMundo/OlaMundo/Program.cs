// See https://aka.ms/new-console-template for more information
Console.WriteLine("Olá, Mundo!");// Saída de dados, impressão em tela
//A segunda palavra inicia com letra maiuscula:
int numeroInteiro = 10; // Declaração de variavel inteira, recebendo o valor 10
long numeroMaior = 1099999L; // Declaração de variavel inteira longa, recebendo o valor 1099999
float numeroQuebrado = 6.8f; // Declaração de nummero quebrado, recebendo o valor 6.8
double numeroQuebradoMaior = 101.99999999D; // Declaração de nummero quebrado, recebendo o valor 101.99999999
char letra = 'z'; // Declaração de variavel char, recebendo letra (1 caracterer)
string texto = "A turam estreito é a melhor"; // Declaração de variavel string, recebendo textos ( + 1 caracter)
bool variavelBooleana = true; // Declaração de variavel booleana, recebendp verdadeiro
DateTime data = DateTime.Now; // Declaração variavel do tipo datetime, recebendo data (até segundos)
DateTime outraData = new DateTime(2023, 01, 31); // Instanciando objeto da classe datetime, passando parametros como mês e dia
texto.ToUpper();// Convertendo o texto para letras maiusculas
Console.WriteLine(texto.ToUpper()); // imprime a frase do texto em maiusculo

string nomeCompleto; // Declaração de variavel 
Console.Write("Digite o seu nome: "); // Instrução ao usuário, Impressão em tela
nomeCompleto = Console.ReadLine(); // Aguardando o usuário digitar no terminal
Console.WriteLine("O seu nome é: " + nomeCompleto); // Saida de dados, concatenando o texto com o valor da variavel



