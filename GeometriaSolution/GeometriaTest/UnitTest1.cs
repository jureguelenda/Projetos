using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometria;
namespace GeometriaTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void CalcularTrapezioCorreto()
    {
        double esperado = 8;
        double resultado = 0;

        GeometriaArea area = new GeometriaArea();
        resultado = area.CalcularAreaTrapezio(2,4,2);

        Assert.AreEqual(esperado,resultado);
    }
}