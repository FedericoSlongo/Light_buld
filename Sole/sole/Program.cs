using System;  
using lampadina_upgraded;

namespace sole
{
    class Program
    {
        static void Main(string[] args)
        {
            string scelta = "";
            Console.WriteLine("Si ha una [lampa]dina\nUna lampa[dina] regolabile\nO una lampadina [RGB]");
            switch (Console.ReadLine().ToLower())
            {
                case "lampa":
                    Console.Clear();
                    lampadina.Lampadina lampa = new lampadina.Lampadina();

                    while (true)
                    {
                        Console.WriteLine("Si vuole:\nCambiare lo [stato] della lampadina\n[Stampa] lo stato");
                        scelta = Console.ReadLine().ToLower();
                        if (scelta == "stato")
                            lampa.stato_change();
                        if (scelta == "stampa")
                            lampa.stampa();
                    }
                case "dina":
                    Console.Clear();
                    lampadina.LampadinaRegolabile lampa_reg = new lampadina.LampadinaRegolabile();

                    while (true)
                    {
                        Console.WriteLine("Si vuole:\nCambiare lo [stato] della lampadina\n[Cambio] potenza\n[Stampa] lo stato");
                        scelta = Console.ReadLine().ToLower();
                        if (scelta == "stato")
                            lampa_reg.stato_change();
                        if (scelta == "stampa")
                            lampa_reg.stampa();
                        if (scelta == "cambio")
                            lampa_reg.change_power(Convert.ToInt32(Console.ReadLine()));
                    }
                case "rgb":
                    Console.Clear();
                    lampadina.LampadinaRGB lampa_gy = new lampadina.LampadinaRGB();

                    while (true)
                    {
                        Console.WriteLine("Si vuole:\nCambiare lo [stato] della lampadina\n[Cambio] potenza\n Cambio colore [RGB]\n[Stampa] lo stato");
                        scelta = Console.ReadLine().ToLower();
                        if (scelta == "stato")
                            lampa_gy.stato_change();
                        if (scelta == "stampa")
                            lampa_gy.stampa();
                        if (scelta == "cambio")
                            lampa_gy.change_power(Convert.ToInt32(Console.ReadLine()));
                        if (scelta == "rgb")
                        {
                            Console.WriteLine("Inserire il colore rosso, verde, blue");
                            lampa_gy.change_color(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                        }
                    }
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
