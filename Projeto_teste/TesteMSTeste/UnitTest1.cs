using Projeto_teste;

namespace TesteMSTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {

            //PREPARACAO - Arrange

            double pNUM = 1;
            double sNUM = 1;
            double rNUM = 2;

            //ACAO - Act

            var resultado = Operacoes.Somar(pNUM, sNUM);

            //VERIFICACAO - Assert
            Assert.AreEqual(rNUM, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(7, 7, 14)]
        public void ListaDeSoma(double pNum, double sNum, double rNum)
        {
            //act
            var resultado = Operacoes.Somar(pNum, sNum);

        // assert
        Assert.AreEqual(rNum, resultado);
        }
    }
}