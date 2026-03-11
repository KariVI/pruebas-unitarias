using Calculadora;

namespace Calculadora.Tests;

public class OperacionesMatematicasTest
{
    [Fact]

    public void Sumar_DosPositivos_RetornaSuma()
    {
        // Arrange
        var operacionesMatematicas = new OperacionesMatematicas();

        int a= 4;
        int b= 5;

        // Act
        var resultado = operacionesMatematicas.Sumar(a, b);

        // Assert
        Assert.Equal(9, resultado);
    }

    [Fact]

    public void Sumar_NegativoPositivo_RetornaValorCorrecto()
    {
        // Arrange
        var operacionesMatematicas = new OperacionesMatematicas();

        int a = -4;
        int b = 5;

        // Act
        var resultado = operacionesMatematicas.Sumar(a, b);

        // Assert
        Assert.Equal(1, resultado);
    }

    [Fact]
    public void Sumar_CeroMasCero_RetornaCero()
    {
        // Arrange
        var operacionesMatematicas = new OperacionesMatematicas();

        int a = 0;
        int b = 0;

        // Act
        var resultado = operacionesMatematicas.Sumar(a, b);

        // Assert
        Assert.Equal(0, resultado);
    }


}