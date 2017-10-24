using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problema001SomaDeMúltiplosDe3Ou5
{
    public class ResoluçãoProblema001SomaDeMúltiplosDe3Ou5
    {
        public int SomaDosMúltiplosDe3Ou5NoPeríodo()
        {
            var operaçõesMatemáticas = new OperaçõesMatemáticas();
            var listaDeMúltiplosDe3Ou5 = new List<int>();
            var listaDeMúltiplosDe3 = operaçõesMatemáticas.IdentificarMúltiplosDeUmNúmeroEmUmPeríodo(3, new Período(0, 999));
            var listaDeMúltiplosDe5 = operaçõesMatemáticas.IdentificarMúltiplosDeUmNúmeroEmUmPeríodo(5, new Período(0, 999));

            listaDeMúltiplosDe3Ou5.AddRange(listaDeMúltiplosDe3);
            listaDeMúltiplosDe3Ou5.AddRange(listaDeMúltiplosDe5);

            return operaçõesMatemáticas.SomarNúmerosDeUmaLista(listaDeMúltiplosDe3Ou5.Distinct().ToList());
        }
    }
}
