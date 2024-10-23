using System;

namespace CSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine();

            string[] v = s.Split(' ');
            string a = v.Length > 0 ? v[0] : "Não foi digitado";
            string b = v.Length > 1 ? v[1] : "Não foi digitado";
            string c = v.Length > 2 ? v[2] : "Não foi digitado";

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine("Pressione Enter para sair...");
            Console.ReadLine();
        }
    }
}using System;

namespace CSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine();

            string[] v = s.Split(' ');
            string a = v.Length > 0 ? v[0] : "Não foi digitado";
            string b = v.Length > 1 ? v[1] : "Não foi digitado";
            string c = v.Length > 2 ? v[2] : "Não foi digitado";

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine("Pressione Enter para sair...");
            Console.ReadLine();
        }
    }
}