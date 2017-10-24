using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problema002SomaDeNúmerosParesFibonacci
{
    public class OperaçõesMatemáticas
    {
        public int SomaDeNúmerosParesDeUmaLista(List<int> números)
        {
            return números.Where(número => número % 2 == 0).Sum();
        }
    }
}
