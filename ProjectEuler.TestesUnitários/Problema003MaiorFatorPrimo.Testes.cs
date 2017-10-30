using FluentAssertions;
using ProjectEuler.Problema003MaiorFatorPrimo;
using System.Collections.Generic;
using Xunit;

namespace ProjectEuler.TestesUnitários
{
    public class Problema003MaiorFatorPrimo
    {
        [Fact]
        public void DeveRetornarOMaiorFatorPrimosDe13195()
        {
            var resultadoMaiorFatorPrimo = 29;
            var operaçõesMatemáticas = new OperaçõesMatemáticas();

            var maiorFatorPrimoDe13195 = operaçõesMatemáticas.IdentificarMaiorFatorPrimosDoNúmero(13195);

            maiorFatorPrimoDe13195.Should().Be(resultadoMaiorFatorPrimo);
        }

        [Fact]
        public void DeveRetornarOsFatoresPrimosDe24()
        {
            var resultadoMaiorFatorPrimo = 3;
            var operaçõesMatemáticas = new OperaçõesMatemáticas();

            var maiorFatorPrimoDe13196 = operaçõesMatemáticas.IdentificarMaiorFatorPrimosDoNúmero(24);

            maiorFatorPrimoDe13196.Should().Be(resultadoMaiorFatorPrimo);
        }

        [Fact]
        public void DeveRetornarOMaiorFatorPrimoDoValor600851475143ComoResoluçãoDoProblema003()
        {
            var resultadoDeMaiorFatorPrimoDoNúmero600851475143 = 6857;
            var operaçõesMatemáticas = new OperaçõesMatemáticas();

            var maiorFatorPriomoDe600851475143 = operaçõesMatemáticas.IdentificarMaiorFatorPrimosDoNúmero(600851475143);

            maiorFatorPriomoDe600851475143.Should().Be(resultadoDeMaiorFatorPrimoDoNúmero600851475143);
        }
    }
}
