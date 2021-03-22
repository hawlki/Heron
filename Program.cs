using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Etec Adolpho Berezin");
            Console.WriteLine("Feito por Israel Camilo Lopes");
            Console.WriteLine("1I3");
            Console.WriteLine("-----------------------------");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Por favor, digite 3 numeros a seguir:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Valor a: ");
            String a = Console.ReadLine();
            Console.Write("Valor b: ");
            String b = Console.ReadLine();
            Console.Write("Valor c: ");
            String c = Console.ReadLine();
            Console.WriteLine();

            Double vlA = Convert.ToDouble(a);
            Double vlB = Convert.ToDouble(b);
            Double vlC = Convert.ToDouble(c);
            Double semiperimetro = (vlA + vlB + vlC) / 2;
            Double area = Math.Sqrt(semiperimetro
                                  *(semiperimetro - vlA) 
                                  *(semiperimetro - vlB) 
                                  *(semiperimetro - vlC) );

           Console.BackgroundColor = ConsoleColor.White;    
           Console.ForegroundColor = ConsoleColor.Black;         
           Console.WriteLine($"O valor do semiperímetro do triângulo é: {semiperimetro}");    
           Console.WriteLine($"O valor da área do triângulo é: {area}");
           Console.WriteLine();

           Console.ResetColor();
           Console.WriteLine("Clique em uma tecla para encerrar este programa");      
           Console.ReadKey();

           Console.Clear();  
        }
    }
}
