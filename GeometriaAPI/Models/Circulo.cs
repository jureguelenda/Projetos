namespace GeometriaAPI.Models
{
    public class Circulo : Geometria, IGeometriaFormulas
    {
        public double CalcularArea(string[] m)
        {
            double raio;

            try
            {
                raio = double.Parse(m[0]); 
            }
            catch(System.Exception)
            {
                return -1;
            }

            return (raio*raio)*3.14;
        }

        public double CalcularPerimetro(string[] m)
        {
            double  raio;  

            try
            {
                raio = double.Parse(m[0]);
                 
            }
            catch(System.Exception )
            {
                return -1;
            }

            return 6.28*raio;
        }
    }
}