using System;
using System.Collections.Generic;

namespace AulaPOOLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cartao> cartoes = new List<Cartao>();

            cartoes.Add(new Cartao("Ronaldinho", "1111-1111-1111-1111", "Visa", 123));
            cartoes.Add(new Cartao("Ednaldo Pereira", "0000-1111-0000-1111", "MasterCard", 456));
            cartoes.Add(new Cartao("José", "1111-2222-2222-1111", "Visa", 789));
            cartoes.Add(new Cartao("Samuel", "6666-1111-1111-6666", "Visa", 354));
            cartoes.Add(new Cartao("João", "7777-8888-1111-1214", "American Express", 798));

            foreach (Cartao c in cartoes)
            {
                Console.WriteLine($"\nTitular: {c.Titular}\nNúmero: {c.Numero}\nBandeira: {c.Bandeira}\n");
            }

        }
    }
}
