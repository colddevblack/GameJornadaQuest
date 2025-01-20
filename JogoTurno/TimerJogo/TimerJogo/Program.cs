using System;
using System.Timers;

namespace TimerJogo
{
    class Program
    {
        static Timer timer = new Timer(3000);
        static int i = 30;
        static void Main(string[] args)
        {
            timer.Elapsed += timer_Elapsed;
            timer.Start(); Console.Read();

        }

        private static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            i--;

            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("                  jogo de turno ");
            Console.WriteLine("");
            Console.WriteLine("                Tempo Restante:  " + i.ToString());
            Console.WriteLine("");
            Console.WriteLine("=================================================");

            if (i == 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("==============================================");
                Console.WriteLine("        ");
                Console.WriteLine("alguns jogadores foram eliminados");
                Console.WriteLine("               G A M E  O V E R");
                Console.WriteLine("==============================================");

                timer.Close();
                timer.Dispose();
            }

            GC.Collect();
        }
    }
}
