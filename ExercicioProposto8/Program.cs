﻿using System;

namespace MyApp
{
    internal class ExercicioProposto8
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero é par.");
            }
            else
            {
                Console.WriteLine("O numero é impar.");
            }
        }
    }
}