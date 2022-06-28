using ProjetoTesteUC15;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrage
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);

        }

        [Theory]
        [InlineData(1,1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 1, 2)]
        public void SomarDoisNumerosLista(double pNum, double snum, double rnum)
        {     
            //Act
            var resultado = Operacoes.Somar(pNum, snum);

            //Assert
            Assert.Equal(rnum, resultado);
        }
    }
}