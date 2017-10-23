using FluentAssertions;
using ProjectEuler.Problema_001_SomaDeMúltiplosDe_3_Ou_5;
using System.Collections.Generic;
using Xunit;

namespace ProjectEuler.TestesUnitários.Problema_001_SomaDeMúltiplosDe_3_Ou_5
{
    public class Problema_001_SomaDeMúltiplosDe_3_Ou_5
    {
        [Fact]
        public void DeveRetornarONúmero_5_ComoRespostaParaOsMúltiplosDe_5_NoIntervaloEntre_0_E_9()
        {
            var resultadoDeMúltiplosDe_5_Entre_0_E_9 = new List<int>() { 5 };
            var númeroQueSeDesejaIdentificarOsMúltiplos = 5;
            var inícioDoIntervaloDesejado = 0;
            var fimDoIntervaloDesejado = 9;

            var períodoDe_0_A_9 = new Período(inícioDoIntervaloDesejado, fimDoIntervaloDesejado);
            var operaçõesMatemáticas = new OperaçõesMatemáticas();
            var múltiplosDe_5_Entre_0_E_9 = operaçõesMatemáticas.IdentificarMúltiplosDeUmNúmeroEmUmPeríodo(númeroQueSeDesejaIdentificarOsMúltiplos, períodoDe_0_A_9);

            múltiplosDe_5_Entre_0_E_9.Should().BeEquivalentTo(resultadoDeMúltiplosDe_5_Entre_0_E_9);
        }

        [Fact]
        public void DeveRetornarOsNúmeros_3_6_E_9_ComoRespostaParaOsMúltiplosDe_3_NoIntervaloEntre_0_E_9()
        {
            var resultadoDeMúltiplosDe_3_Entre_0_E_9 = new List<int>() { 3, 6, 9 };
            var númeroQueSeDesejaIdentificarOsMúltiplos = 3;
            var inícioDoIntervaloDesejado = 0;
            var fimDoIntervaloDesejado = 9;

            var períodoDe_0_A_9 = new Período(inícioDoIntervaloDesejado, fimDoIntervaloDesejado);
            var operaçõesMatemáticas = new OperaçõesMatemáticas();
            var múltiplosDe_3_Entre_0_E_9 = operaçõesMatemáticas.IdentificarMúltiplosDeUmNúmeroEmUmPeríodo(númeroQueSeDesejaIdentificarOsMúltiplos, períodoDe_0_A_9);

            múltiplosDe_3_Entre_0_E_9.Should().BeEquivalentTo(resultadoDeMúltiplosDe_3_Entre_0_E_9);
        }
        
        [Fact]
        public void DeveRetornarONúmero_23_ComoRespostaParaASomaDeUmaListaDeNúmerosQueContenha_3_5_6_E_9()
        {
            var resultadoDaSoma = 23;
            var listaDeNúmeros = new List<int>() { 3, 5, 6, 9 };

            var operaçõesMatemáticas = new OperaçõesMatemáticas();
            var somaDaListaDeNúmeros = operaçõesMatemáticas.SomarNúmerosDeUmaLista(listaDeNúmeros);
            
            resultadoDaSoma.Should().Be(somaDaListaDeNúmeros);
        }

        [Fact]
        public void DeveRetornarOValor_233168_ComoResoluçãoDoProblema_001()
        {
            var resultadoDaSomaDeMúltiplos = 233168;

            var resoluçãoDoProblema_001 = new ResoluçãoProblema_001_SomaDeMúltiplosDe_3_Ou_5();
            var respostaParaProblema_001 = resoluçãoDoProblema_001.SomaDosMúltiplosDe_3_Ou_5_Entre_0_E_999();

            respostaParaProblema_001.Should().Be(resultadoDaSomaDeMúltiplos);
        }
    }
}
