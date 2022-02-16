using System;
using System.Threading;

namespace Frazioni_Esame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OPERAZIONE TRA 2 FRAZIONI\n");
            Frazione f1 = new Frazione();
            Frazione f2 = new Frazione();
            Thread.Sleep(1500);
            Console.WriteLine("Frazione 1:");
            f1.Numeratore = int.Parse(Console.ReadLine());
            Console.WriteLine("/");
            f1.Denominatore = int.Parse(Console.ReadLine());
            Console.WriteLine("Frazione 2:");
            f2.Numeratore = int.Parse(Console.ReadLine());
            Console.WriteLine("/");
            f2.Denominatore = int.Parse(Console.ReadLine());

            Console.WriteLine($"Frazione 1: {f1.ToString()}\n");
            Console.WriteLine($"Frazione 2: {f2.ToString()}\n\n");

            Console.WriteLine("Cosa vuoi Fare? \n" +
                "1. Addizione\n2. Sottrazione\n3. Montiplicazione\n4. Divisione\n9. Esci");
            string i = Console.ReadLine();
            switch(i)
            {
                case "1":
                case "+":
                    
                    Console.WriteLine("\n{0} + {1} = {2}", f1.ToString(), f2.ToString(), Frazione.Addizione(f1, f2).ToString());
                    Console.ReadLine();
                    break;
                case "2": 
                case "-":
                    Console.WriteLine("\n{0} -{1} = {2}", f1.ToString(), f2.ToString(), Frazione.Sottrazione(f1, f2).ToString());
                    Console.ReadLine();
                    break;
                    
                case "3":
                case "x":
                    Console.WriteLine("\n{0} x {1} = {2}", f1.ToString(), f2.ToString(), Frazione.Moltiplicazione(f1, f2).ToString());
                    Console.ReadLine();
                    break;

                case "4":
                case ":":
                    Console.WriteLine("\n{0} : {1} = {2}", f1.ToString(), f2.ToString(), Frazione.Divisione(f1, f2).ToString());
                    Console.ReadLine();
                    break;
                case "9":
                    Environment.Exit(0);
                    break;
                default:
                    break;

            }
            
         }
    }
}
