using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problema_001_SomaDeMúltiplosDe_3_Ou_5
{
    public class OperaçõesMatemáticas
    {
        private int _InícioDoPeríodo;
        private int _FimDoPeríodo;

        public List<int> IdentificarMúltiplosDeUmNúmeroEmUmPeríodo(int número, Período período)
        {
            if (número == 0)
                throw new Exception("O número deve ser diferente de zero");

            _InícioDoPeríodo = período.Início;
            _FimDoPeríodo = período.Fim;

            var listaDeMúltiplos = new List<int>();

            for(int i = _InícioDoPeríodo; i <= _FimDoPeríodo; i++)
            {
                if (i == 0) continue;

                if (i % número == 0)
                    listaDeMúltiplos.Add(i);
            }

            return listaDeMúltiplos;
        }

        public int SomarNúmerosDeUmaLista(List<int> listaDeNúmeros)
        {
            return listaDeNúmeros.Sum();
        }

    }
}
