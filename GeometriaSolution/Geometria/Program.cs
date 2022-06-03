using System;

namespace Geometria
{
   class program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Calculando Areas");

           Console.WriteLine("Digite a base: ");
           double b = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Digite a altura: ");
           double a = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Digite o raio: ");
           double r = Convert.ToDouble(Console.ReadLine());

           GeometriaArea geo = new GeometriaArea();

           double resultado = geo.CalcularAreaRetangulo(b,a);

           Console.WriteLine($"O resultado do retangulo é:  {resultado}");

           Console.WriteLine("Calcular Triangulo");
           resultado = geo.CalcularAreaTriangulo(2,3,4,"r");

           Console.WriteLine($"O resultado da area do Triangulo é:  {resultado}");

           Console.WriteLine("Calcular Circulo");
           resultado = geo.CalcularAreaCirculo(r);
           Console.WriteLine($"O resultado da area do Circulo é:  {resultado}");
       }
   }

}
