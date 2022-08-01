using System;

namespace Calculadora
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Operações válidas: +, -, * (multiplicação), / (divisão");
                Console.WriteLine("Digite a operação no seguinte formato e aperte enter para executar: {número} {operação} {número}");
                Console.WriteLine("Exemplo: 150 + 145");
                Console.WriteLine("Para encerrar, aperte Ctrl + C\n");
                try{
                    string[] scanf = Console.ReadLine().Split();
                    float a = float.Parse(scanf[0]);
                    char operacao = char.Parse(scanf[1]);
                    float b = float.Parse(scanf[2]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Resultado: ");
                    switch(operacao) {
                        case '+':
                            Console.WriteLine($"{a+b}\n", a, b);
                            Console.WriteLine("Pressione enter para executar outra operação ou aperte Ctrl + C para sair");
                            Console.ReadKey();
                            break;
                        case '-':
                            Console.WriteLine($"{a-b}\n", a, b);
                            Console.WriteLine("Pressione enter para executar outra operação ou aperte Ctrl + C para sair");
                            Console.ReadKey();
                            break;
                        case '*':
                            Console.WriteLine($"{a*b}\n", a, b);
                            Console.WriteLine("Pressione enter para executar outra operação ou aperte Ctrl + C para sair");
                            Console.ReadKey();
                            break;
                        case '/':
                            Console.WriteLine($"{a/b}\n", a, b);
                            Console.WriteLine("Pressione enter para executar outra operação ou aperte Ctrl + C para sair");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Operação inválida, aperte enter para tentar novamente!");
                            Console.ReadKey();
                            break;
                    }
                } catch(IndexOutOfRangeException e) {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opa! Parece que você digitou alguma coisa errada... Aperte enter e tente novamente!");
                    Console.ReadLine();
                    Console.ResetColor();
                } catch(System.FormatException e) {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opa! Parece que você digitou alguma coisa errada... Aperte enter e tente novamente!");
                    Console.ReadLine();
                    Console.ResetColor();
                }   
            }   
        }
    }
}