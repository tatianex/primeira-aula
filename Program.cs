using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Tatiane";
            var age = 28;
            var grade = 9.5;
            var study = true;

            Console.WriteLine("Qual é o seu nome?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Olá, seja bem vindo {userName}!");
            Console.WriteLine("Você é maior de idade?");
            var amIlegalAge = Console.ReadLine() == "sim";

            Console.WriteLine(study);
        }
    }
}
