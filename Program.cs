using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso em quilogramas:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite sua altura em metros:");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("\nSeu IMC é: " + Math.Round(imc, 2));

            if (imc < 18.5)
            {
                Console.WriteLine("\nAbaixo do peso");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("\nPeso normal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("\nSobrepeso");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("\nObesidade grau 1");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("\nObesidade grau 2");
            }
            else
            {
                Console.WriteLine("\nObesidade grau 3");
            }

            Console.ReadKey();
        }
    }
}