using Calculadora.Models;

namespace CalculadoraTest;

public class UnitTest1
{
    private CalculadoraImp _calculadora()
    {
        return new CalculadoraImp();
    }


    [Theory]
    [InlineData(1.0, 1.0, 2.0)]
    [InlineData(4.5, 2.5, 7.0)]
    [InlineData(2.34, 5.78, 8.12)]
    public void TesteDeSoma(decimal num1, decimal num2, decimal res)
    {
        CalculadoraImp calc = _calculadora();

        Assert.Equal(res, calc.Somar(num1, num2));
    }

    [Theory]
    [InlineData(1.0, 1.0, 0.0)]
    [InlineData(4.5, 2.5, 2.0)]
    [InlineData(17.56, 5.78, 11.78)]
    public void TesteDeSubtracao(decimal num1, decimal num2, decimal res)
    {
        CalculadoraImp calc = _calculadora();

        Assert.Equal(res, calc.Subtrair(num1, num2));
    }

    [Theory]
    [InlineData(1.0, 1.0, 2.0)]
    [InlineData(4.5, 2.5, 11.25)]
    [InlineData(2.34, 5.78, 13.5252)]
    public void TesteDeMultiplicacao(decimal num1, decimal num2, decimal res)
    {
        CalculadoraImp calc = _calculadora();

        Assert.Equal(res, calc.Multiplicar(num1, num2));
    }

    [Theory]
    [InlineData(1.0, 1.0, 1.0)]
    [InlineData(4.5, 2.5, 1.8)]
    [InlineData(15.25, 5.0, 3.05)]
    public void TesteDeDivisao(decimal num1, decimal num2, decimal res)
    {
        CalculadoraImp calc = _calculadora();

        Assert.Equal(res, calc.Dividir(num1, num2));
    }

    [Fact]
    public void DivisaoPorZero()
    {
        decimal num1 = 3.5M;
        decimal num2 = 0.0M;
        CalculadoraImp calc = _calculadora();


        Assert.Throws<DivideByZeroException>(() => calc.Dividir(num1, num2));

    }

    [Theory]
    [InlineData(1.0, 1.0, 2.0)]
    [InlineData(4.5, 2.5, 7.0)]
    [InlineData(2.34, 5.78, 8.12)]
    public void TesteHistorico(decimal num1, decimal num2, decimal res)
    {
        CalculadoraImp calc = _calculadora();
        calc.Somar(num1, num2);

        Assert.Equal(res, calc.UltimoResultado());
    }


}