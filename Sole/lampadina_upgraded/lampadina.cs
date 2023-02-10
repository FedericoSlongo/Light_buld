using System;
using System.Collections.Generic;
using System.Drawing;

namespace lampadina_upgraded
{
    public class lampadina
    {

        public class Lampadina
        {
            protected static ConsoleColor ClosestConsoleColor(byte r, byte g, byte b)
            {
                ConsoleColor ret = 0;
                double rr = r, gg = g, bb = b, delta = double.MaxValue;

                foreach (ConsoleColor cc in Enum.GetValues(typeof(ConsoleColor)))
                {
                    var n = Enum.GetName(typeof(ConsoleColor), cc);
                    var c = System.Drawing.Color.FromName(n == "DarkYellow" ? "Orange" : n); // bug fix
                    var t = Math.Pow(c.R - rr, 2.0) + Math.Pow(c.G - gg, 2.0) + Math.Pow(c.B - bb, 2.0);
                    if (t == 0.0)
                        return cc;
                    if (t < delta)
                    {
                        delta = t;
                        ret = cc;
                    }
                }
                return ret;
            }


            public int potenza { get; protected set; }
            public bool stato { get; protected set; }

            public Lampadina()
            {
                potenza = 60;
                stato = false;
            }
            public void stato_change() { stato = !stato; }


            public void stampa()
            {
                if (!stato)
                {
                    Console.WriteLine("" +
                        " _ \n" +
                        "(~)\n" +
                        " #\n");
                    return;
                }
                Console.WriteLine($"La potenza è : {potenza}");
                Console.WriteLine(@"     :
 '.  _  .'
 -= (~) = -
 .'  #  '.");
            }
        }

        public class LampadinaRegolabile : Lampadina
        {
            public void change_power(int power)
            {
                potenza = power;
            }
        }

        public class LampadinaRGB : LampadinaRegolabile
        {
            public int rosso { get; private set; }
            public int verde { get; private set; }
            public int blu { get; private set; }
            public void change_color(int rosso, int verde, int blue)
            {
                blu = blue;
                this.verde = verde;
                this.rosso = rosso;
            }
            public void stampa()
            {
                Console.WriteLine($"La potenza è : {potenza}");
                Console.ForegroundColor = ClosestConsoleColor((byte)rosso, (byte)verde, (byte)blu);
                if (!stato)
                {
                    Console.WriteLine("" +
                        " _ " +
                        "(~)" +
                        " #");
                    return;
                }
                Console.WriteLine(@"     :
 '.  _  .'
 -= (~) = -
 .'  #  '.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public class LedStrip
        {
            //public List<LampadinaRGB> striscia = new List<LampadinaRGB>();
        }
    }
}
