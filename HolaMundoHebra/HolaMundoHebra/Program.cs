using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HolaMundoHebra
{
    public class Program
    {
        static void ejecutar()
        {
                int i = Convert.ToInt32(Thread.CurrentThread.Name);
                Thread.Sleep(i*1000);
                Console.WriteLine("Hola hebra nro {0}", i);
           }
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Hebras");
            for (int i=1; i<7; i++)
            {
                Thread t = new Thread(new ThreadStart(ejecutar));
                t.Name = i.ToString();
                t.Start();
            }
            Console.WriteLine("Hebras iniciadas");
            
           
            Console.ReadKey();
        }
    }
}
