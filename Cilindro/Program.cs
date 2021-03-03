﻿using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            string heightStr, radiusStr;
            float height, radius;
            float pi = 3.1415926f;
            float vol, supArea;

            //Pedir a altura
            Console.Write("Escreva uma altura: ");
            heightStr = Console.ReadLine();

            //Pedir raio
            Console.Write("Escreva um raio: ");
            radiusStr = Console.ReadLine();

            //Coverter tudo
            height = Convert.ToSingle(heightStr);
            radius = float.Parse(radiusStr);

            //Calcular o volume
            vol = pi * radius * radius * height;

            //Calculr a area superficial
            supArea = 2 * pi * radius * (radius * height);

            //Mostra o volume
            Console.Write($"Volume is {vol}.");

            //Mostrar a area superficial
            Console.Write("A area superficial is {0}.", supArea);
        }
    }
}