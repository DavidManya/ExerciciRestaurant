﻿using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        public class Tria
        {
            public string NomPlat { get; set; }
        }

        static void Main(string[] args)
        {
            //Fase 1
            int bitllet5 = 5;
            int bitllet10 = 10;
            int bitllet20 = 20;
            int bitllet50 = 50;
            int bitllet100 = 100;
            int bitllet200 = 200;
            int bitllet500 = 500;

            string plat1 = "";
            string plat2 = "";
            string plat3 = "";
            string plat4 = "";
            string plat5 = "";

            double preu1 = 0.0;
            double preu2 = 0.0;
            double preu3 = 0.0;
            double preu4 = 0.0;
            double preu5 = 0.0;

            string[] ArrayMenu = {plat1, plat2, plat3, plat4, plat5};
            double[] ArrayPreu = {preu1, preu2, preu3, preu4, preu5};

            //Fase 2
            //Introduïr plats del menú i el seu preu
            int numplat = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char Euro = '€';
            
            Console.WriteLine("Introduïu 5 plats pel menú:");
            for (int i = 0; i < 5; i++)
            {
                numplat = i + 1;
                Console.WriteLine($"Nom plat {numplat} (prem enter) i el seu preu 00,00 (prem enter)");
                ArrayMenu[i] = Console.ReadLine();
                ArrayPreu[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("------------------");
            Console.WriteLine("Aquest és el Menú:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{ArrayMenu[i]} - {ArrayPreu[i]}{Euro}"  );
            }

            List<Tria> listTria = new List<Tria>();
            int prou = 1;

            Console.WriteLine("Trieu i escribiu el nom del plat que voleu (prem Enter):");
            while (prou > 0)
            {
                listTria.Add(new Tria { NomPlat = Console.ReadLine() });
                Console.WriteLine("Voleu afegir algún plat més? (1:Si / 0:No)");
                prou = Convert.ToInt32(Console.ReadLine());
            }
            foreach (Tria p in listTria)
            {
                Console.WriteLine(p.NomPlat);
            }
        }
    }
}
