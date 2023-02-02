using System;  
using lampadina_upgraded;

namespace sole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Si ha una [lampa]dina\nUna lampa[dina] regolabile\nO una lampadina [RGB]");
            switch (Console.ReadLine().ToLower())
            {
                case "lampa":
                    Console.Clear();
                    lampadina.Lampadina lampa = new lampadina.Lampadina();

                    while (true)
                    {
                        Console.WriteLine("Si vuole:\nCambiare lo [stato] della lampadina");
                        if (Console.ReadLine().ToLower())
                            lampa.stato_change();

                    }
                    break;
                case "dina":
                    Console.Clear();
                    lampadina.LampadinaRegolabile lampa_reg = new lampadina.LampadinaRegolabile();
                    break;
                case "rgb":
                    Console.Clear();
                    lampadina.LampadinaRGB lampa_gy = new lampadina.LampadinaRGB();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("no");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
