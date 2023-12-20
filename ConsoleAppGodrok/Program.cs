using System;

namespace ConsoleAppGodrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> melysegLista = File.ReadLines("C:\\Users\\barizs.marton.daniel\\Dolgok\\e_inffor_21maj_fl\\4_Godrok\\melyseg.txt")
                .Select(x => Convert.ToInt32(x))
                .ToList();

            // 1. feladat
            Console.WriteLine($"1. feladat: enniy fajl van: {melysegLista.Count}");

            // 2. feladat
            Console.Write($"2. feladat: Adjon meg egy távolságértéket: ");
            int tavErt = int.Parse(Console.ReadLine());

            // 3. feladat
            Console.WriteLine(Math.Round(Convert.ToDouble(melysegLista.Count(x => x == 0)) / melysegLista.Count * 100,2));

            // 4. feladat
            string sor = "";
            List<string> godrok = new List<string>();
            foreach (var item in melysegLista)
            {
                if (item == 0)
                {
                    godrok.Add(sor);
                    sor = "";

                }
                else
                {
                    sor += item;
                }
            }
            
            File.WriteAllLines("godrok.txt",godrok.Where(x => x != ""));

            // 5. feladat
            Console.WriteLine($"Gödrök száma: {godrok.Count}");


        }
    }
}