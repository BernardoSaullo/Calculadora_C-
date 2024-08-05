using System;

namespace Calculadora
{
    class Program 
    {
        static void Main(string[] args)
        {
            bool verifica_n1 = false;
            bool verifica_sinal = false;
            bool verifica_n2 = false;
            var operador = "";

            float n1 = 0;
            float n2 = 0;

            Console.Write("Primeiro numero: ");
            while(!verifica_n1)
            {
                if(!float.TryParse(Console.ReadLine(), out n1))
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um numero válido");
                    Console.Write("Primeiro numero: ");
                }
                else
                {
                    verifica_n1 = true;
                }
            }

            while(!verifica_sinal)
            {
                Console.Write("Operador: ");
                operador = Console.ReadLine();
                if (operador == "+" || operador == "-" || operador == "x" || operador == "/")
                {
                    verifica_sinal = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um operador válido");
                    Console.Write("Operador: ");
                }
            }

            Console.Write("Segundo numero: ");
            while(!verifica_n2)
            {
                if(!float.TryParse(Console.ReadLine(), out n2))
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um numero válido");
                    Console.Write("Segundo numero: ");
                }
                else
                {
                    verifica_n2 = true;
                }
            }

            if (operador == "+")
            {
                somar(n1, n2);
            }
            else if (operador == "-")
            {
                subtrair(n1, n2);
            }
            else if (operador == "x")
            {
                multiplicar(n1, n2);
            }
            else if (operador == "/")
            {
                dividir(n1, n2);
            }
        }

        static void somar(float x, float y)
        {
            Console.Write($"{x} + {y} = {x + y}");
        }

        static void subtrair(float x, float y)
        {
            Console.Write($"{x} - {y} = {x - y}");
        }

        static void multiplicar(float x, float y)
        {
            Console.Write($"{x} x {y} = {x * y}");
        }

        static void dividir(float x, float y)
        {   
            if (y == 0)
            {
                Console.Write("Não é possível dividir um número por 0");
            }
            else
            {
                Console.Write($"{x} / {y} = {x / y}");
            }
        }
    }   
}
