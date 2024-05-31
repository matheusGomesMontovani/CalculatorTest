using Calculator;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        public void TestSoma(int num1, int num2, int resultado)
        {
            Calculadora calcular = new Calculadora();

            int somar = calcular.Soma(num1, num2);

            Assert.Equal(resultado, somar);
        }

        [Theory]
        [InlineData(10, 20, -10)]
        public void TestSubtracao(int num1, int num2, int resultado)
        {
            Calculadora calcular = new Calculadora();

            int subtrair = calcular.Subtracao(num1, num2);

            Assert.Equal(resultado, subtrair);
        }

        [Theory]
        [InlineData(10, 10, 100)]
        public void TestMultiplicaao(int num1, int num2, int resultado)
        {
            Calculadora calcular = new Calculadora();

            int multiplicacao = calcular.Multiplicacao(num1, num2);

            Assert.Equal(resultado, multiplicacao);
        }

        [Theory]
        [InlineData(10, 10, 1)]
        public void TestDivisao(int num1, int num2, int resultado)
        {
            Calculadora calcular = new Calculadora();

            int divisao = calcular.Divisao(num1, num2);

            Assert.Equal(resultado, divisao);
        }
    }
}