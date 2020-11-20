using System;
using System.Collections.Generic;

namespace TemaExemploListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); // Lista de strings
            list.Add("Fabio"); list.Add("Wilson"); list.Add("Angelina"); list.Add("Elinei"); list.Add("Andre"); // Elementos da lista
            list.Insert(2, "Lucas");
            foreach (string obj in list) // Loop para ler os elementos
            {
                Console.WriteLine(obj); // Mostra o elemento 
            }
            Console.WriteLine("Quantos elementos têm a Lista: " + list.Count); // Quantidade de elementos da lista
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1); // Encontra o primeiro elemento que inicia com a letra A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último elemento que começa com a letra A: " + s2); // Encontra o ultimo elemento que inicia com a letra A
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira Posição de 'A': " + pos1); // Busca elementos pela posição
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última Posição de 'A': " + pos2);
            List<string> list2 = list.FindAll(x => x.Length == 5); // Busca todos elementos com tamanho de 5 caracteres
            Console.WriteLine("---------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            list.Remove("Andre"); // Remover elementos da lista
            Console.WriteLine("===========================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAll(x => x[0] == 'W'); // Remover determinado elemento da Lista
            Console.WriteLine("+++++++++++++++++++++++++++");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAt(3); // Remover determinado elemento pela posição
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveRange(1, 2); // Remover elementos da lista a partir da posição e quantos elementos
            Console.WriteLine("___________________________");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}