using System;

namespace Geometria
{
   public class GeometriaArea
   {
       public double Area { get; set; }
       public string Cor { get; set; }

       public double CalcularAreaRetangulo (double basev, double altura)
       {
            double resultado = basev * altura;
            this.Area= resultado;

            return resultado;
       }

       // tipo i= isosceles, e= equilatero, r= retangulo
       public double CalcularAreaTriangulo(double a, double b, double c, string tipo)
       {
           double resultado;
           if(tipo=="r")
           {
               resultado = (a*b)/2;
           }
           else if(tipo=="e")
           {
               resultado = (b*b *1.7)/4;
           }
            else if(tipo=="i")
           {
               resultado = (a*b)/2;
           }
            else
           {
               resultado = 0;
           }

           return resultado;
       }

       public double CalcularAreaCirculo(double r)
       {
           double resultado = r*r * 3.14;

           return resultado;
       }

        public double CalcularAreaTrapezio (double b, double B, double h)
       {
           return ((B*b)*h)/2;
       }
   }
}