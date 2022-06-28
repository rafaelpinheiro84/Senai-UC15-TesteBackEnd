using Microsoft.VisualStudio.TestTools.UnitTesting;
using IMC;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        public void CalcularIMC()
        {
            //Arrange
            double altura = 1.80;
            double peso = 80.0;
            string total = "24,7";

            //Act 
            var resultado = CalculoIMC.CalcularIMC(peso, altura).ToString("#.#");

            //Assert
            Assert.AreEqual(total, resultado);
        }

        
        public void ClassificarIMC()
        {
            //Arrange
            double IMC = 24.7;
            string categoria = "Peso normal";

            //Act
            var resultado = CalculoIMC.ClassificarIMC(IMC);

            //Assert
            Assert.AreEqual(categoria, resultado);
        }
    }
}