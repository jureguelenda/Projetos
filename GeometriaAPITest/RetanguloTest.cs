
using GeometriaAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace GeometriaAPITest
{
  [TestClass]
     public class RetanguloTest
{
    Retangulo retangulo = new Retangulo();

     [TestMethod]
    public void RetenguloCalcularAreaTestAccept()
    {
        
        double esperado = 20;
        string[] medidas = {"4","5"};
        double resultado = retangulo.CalcularArea(medidas);

        Assert.AreEqual(esperado,resultado);
    }

       public void RetanguloCalcularTestcomTextoPrimriraPosicao()
    {
        double esperado = -1;
        string[] medidas = {"m","5"};
        double resultado = retangulo.CalcularArea(medidas);

        Assert.AreEqual(esperado,resultado);
    }

    [TestMethod]

    public void RetanguloCalcularTestcomTextoSegundaPosicao()
    {
        double esperado = -1;
        string[] medidas = {"4","5"};
        double resultado = retangulo.CalcularArea(medidas);

        Assert.AreEqual(esperado,resultado);
    }

    [TestMethod]

    public void RetanguloCalcularPerimetroCorreto()
    {
        double esperado = 18;
        string[] medidas = {"4","5"};
        double resultado = retangulo.CalcularArea(medidas);

        Assert.AreEqual(esperado,resultado);

    }

  }
}