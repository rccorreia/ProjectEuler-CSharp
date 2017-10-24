using FluentAssertions;
using ProjectEuler.Problema002SomaDeNúmerosParesFibonacci;
using System.Collections.Generic;
using Xunit;

namespace ProjectEuler.TestesUnitários
{
    public class Problema002SomaDeNúmerosParesFibonacci
    {
        [Fact]
        public void DeveRetornarOsNúmerosDeFibonacciMenoresOuIguaisA10()
        {
            var resultadoNúmerosDeFibonacci = new List<int>() { 1, 2, 3, 5, 8 };
            var fibonacci = new Fibonacci();

            var númerosDeFibonacciNoPeríodo = fibonacci.NúmerosDeFibonacciMenoresOuIguaisAoNúmeroMáximo(10);

            númerosDeFibonacciNoPeríodo.Should().BeEquivalentTo(resultadoNúmerosDeFibonacci);
        }

        [Fact]
        public void DeveRetornarOResultadoDaSomaDosNúmerosParesIndicados()
        {
            var números = new List<int>() { 1, 2, 3, 5, 8 };
            var operaçõesMatemáticas = new OperaçõesMatemáticas();

            var somaDosNúmerosPares = operaçõesMatemáticas.SomaDeNúmerosParesDeUmaLista(números);

            somaDosNúmerosPares.Should().Be(10);
        }

        [Fact]
        public void DeveRetornarOValorResultanteDaSomaDeNúmerosParesDeFibonacciAbaixoDe4MilhõesComoResoluçãoDoProblema002()
        {
            var resultadoDaSomaDeNúmerosParesDeFibonnaciAté4Milhões = 4613732;

            var resoluçãoDoProblema002 = new ResoluçãoProblema002SomaDeNúmerosParesFibonacci();
            var respostaParaProblema002 = resoluçãoDoProblema002.SomaDosNúmerosParesFibonacciAté4Milhões();

            respostaParaProblema002.Should().Be(resultadoDaSomaDeNúmerosParesDeFibonnaciAté4Milhões);
        }
    }
}
