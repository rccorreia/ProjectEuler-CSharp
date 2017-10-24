using FluentAssertions;
using ProjectEuler.Problema001SomaDeMúltiplosDe3Ou5;
using System.Collections.Generic;
using Xunit;

namespace ProjectEuler.TestesUnitários
{
    public class Problema001SomaDeMúltiplosDe3Ou5
    {
        [Fact]
        public void DeveRetornarOsNúmerosMúltiplosDe5NoIntervaloIndicado()
        {
            var resultadoDeMúltiplosDe5 = new List<int>() { 5 };
            var operaçõesMatemáticas = new OperaçõesMatemáticas();

            var múltiplosDe5NoPeríodo = operaçõesMatemáticas.IdentificarMúltiplosDeUmNúmeroEmUmPeríodo(5, new Período(0,9));

            múltiplosDe5NoPeríodo.Should().BeEquivalentTo(resultadoDeMúltiplosDe5);
        }

        [Fact]
        public void DeveRetornarOsNúmerosMúltiplosDe3NoIntervaloIndicado()
        {
            var resultadoDeMúltiplosDe3 = new List<int>() { 3, 6, 9 };
            var operaçõesMatemáticas = new OperaçõesMatemáticas();

            var múltiplosDe3NoPeríodo = operaçõesMatemáticas.IdentificarMúltiplosDeUmNúmeroEmUmPeríodo(3, new Período(0, 9));

            múltiplosDe3NoPeríodo.Should().BeEquivalentTo(resultadoDeMúltiplosDe3);
        }
        
        [Fact]
        public void DeveRetornarONúmeroResultanteDaSomaDeUmaListaDeNúmeros()
        {
            var resultadoDaSoma = 23;
            var listaDeNúmeros = new List<int>() { 3, 5, 6, 9 };

            var operaçõesMatemáticas = new OperaçõesMatemáticas();
            var somaDaListaDeNúmeros = operaçõesMatemáticas.SomarNúmerosDeUmaLista(listaDeNúmeros);
            
            resultadoDaSoma.Should().Be(somaDaListaDeNúmeros);
        }

        [Fact]
        public void DeveRetornarOValorResultanteDaSomaDeMúltiplosDe3Ou5ComoResoluçãoDoProblema001()
        {
            var resultadoDaSomaDeMúltiplosDe3Ou5Entre0E999 = 233168;

            var resoluçãoDoProblema001 = new ResoluçãoProblema001SomaDeMúltiplosDe3Ou5();
            var respostaParaProblema001 = resoluçãoDoProblema001.SomaDosMúltiplosDe3Ou5NoPeríodo();

            respostaParaProblema001.Should().Be(resultadoDaSomaDeMúltiplosDe3Ou5Entre0E999);
        }
    }
}
