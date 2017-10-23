using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problema_001_SomaDeMúltiplosDe_3_Ou_5
{
    public class ResoluçãoProblema_001_SomaDeMúltiplosDe_3_Ou_5
    {
        public int SomaDosMúltiplosDe_3_Ou_5_Entre_0_E_999()
        {
            var operaçõesMatemáticas = new OperaçõesMatemáticas();
            var listaDeMúltiplosDe_3_Ou_5 = new List<int>();

            var listaDeMúltiplosDe_3 = operaçõesMatemáticas.IdentificarMúltiplosDeUmNúmeroEmUmPeríodo(3, new Período(0, 999));
            var listaDeMúltiplosDe_5 = operaçõesMatemáticas.IdentificarMúltiplosDeUmNúmeroEmUmPeríodo(5, new Período(0, 999));

            listaDeMúltiplosDe_3_Ou_5.AddRange(listaDeMúltiplosDe_3);
            listaDeMúltiplosDe_3_Ou_5.AddRange(listaDeMúltiplosDe_5);
            listaDeMúltiplosDe_3_Ou_5 = listaDeMúltiplosDe_3_Ou_5.Distinct().ToList();

            return operaçõesMatemáticas.SomarNúmerosDeUmaLista(listaDeMúltiplosDe_3_Ou_5);
        }
    }
}
