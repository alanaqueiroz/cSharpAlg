﻿using System;

namespace CSharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false; //true ou false
            char genero = 'F';
            char letra = '\u0041'; //código unicode do A maiúsculo
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4  = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria"; //1 caracter aspas simples, dois caracteres aspas duplas

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
        }
    }
}
