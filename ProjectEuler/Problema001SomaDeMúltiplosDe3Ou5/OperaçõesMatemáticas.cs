using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problema001SomaDeMúltiplosDe3Ou5
{
    public class OperaçõesMatemáticas
    {
        private int _inícioDoPeríodo;
        private int _fimDoPeríodo;

        public List<int> IdentificarMúltiplosDeUmNúmeroEmUmPeríodo(int número, Período período)
        {
            if (número == 0)
                throw new Exception("O número deve ser diferente de zero");

            _inícioDoPeríodo = período.Início;
            _fimDoPeríodo = período.Fim;

            var listaDeMúltiplos = new List<int>();

            for(int i = _inícioDoPeríodo; i <= _fimDoPeríodo; i++)
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
