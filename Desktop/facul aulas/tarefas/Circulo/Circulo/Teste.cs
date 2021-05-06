using System;

namespace Circulo
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            const double PI = 3.1416;
            double raio = 0;
            double area = 0;

           
            Console.Write("Entre com o raio do circulo : ");
            raio = double.Parse(Console.ReadLine());  

            
            area = PI * (raio * raio);

         
            Console.Write("Área do Círculo : " + area);

            Console.ReadKey();

        }
    }
}
