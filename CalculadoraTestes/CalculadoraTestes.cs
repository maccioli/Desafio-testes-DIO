using Calculadora.Services;
namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar10Com10Retornar20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;
        //Act
        int resultado = _calc.Somar(num1, num2);
        //Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveSubtrair5De15Retornar10()
    {
        //Arrange
        int num1 = 15;
        int num2 = 5;
        //Act
        int resultado = _calc.Subtrair(num1, num2);
        //Assert
        Assert.Equal(10, resultado);
    }

    [Fact]
    public void DeveDividir20Por4Retornar5()
    {
        //Arrange
        int num1 = 20;
        int num2 = 4;
        //Act
        int resultado = _calc.Dividir(num1, num2);
        //Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void DeveMultiplicar20Por20Retornar400()
    {
        //Arrange
        int num1 = 20;
        int num2 = 20;
        //Act
        int resultado = _calc.Multiplicar(num1, num2);
        //Assert
        Assert.Equal(400, resultado);
    }
}