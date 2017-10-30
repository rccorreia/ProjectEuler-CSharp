using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problema003MaiorFatorPrimo
{
    public class OperaçõesMatemáticas
    {
        private long _númeroAuxiliar;

        public long IdentificarMaiorFatorPrimosDoNúmero(long número)
        {
            if (número % 2 == 0)
                return IdentificarMaiorFatorPrimosDoNúmeroPar(número);
            else
                return IdentificarMaiorFatorPrimosDoNúmeroÍmpar(número);
        }

        private long IdentificarMaiorFatorPrimosDoNúmeroPar(long númeroPar)
        {
            long maiorFatorPrimo;
            _númeroAuxiliar = númeroPar / 2;

            while (_númeroAuxiliar % 2 == 0)
                _númeroAuxiliar = _númeroAuxiliar / 2;

            maiorFatorPrimo = _númeroAuxiliar;

            return maiorFatorPrimo;
        }

        private long IdentificarMaiorFatorPrimosDoNúmeroÍmpar(long númeroÍmpar)
        {
            long maiorFatorPrimo;
            if (númeroÍmpar <= 1) return 0;
            long _númeroAuxiliar = númeroÍmpar;

            long fator = 3;
            var fatorMáximo = Math.Sqrt(_númeroAuxiliar);
            long últimoFator = 0;

            while (_númeroAuxiliar > 1 && fator <= fatorMáximo)
            {
                if (_númeroAuxiliar % fator == 0)
                {
                    _númeroAuxiliar = _númeroAuxiliar / fator;
                    últimoFator = fator;
                    while (_númeroAuxiliar % fator == 0)
                        _númeroAuxiliar = _númeroAuxiliar / fator;

                    fatorMáximo = Math.Sqrt(_númeroAuxiliar);
                }

                fator += 2;
            }

            maiorFatorPrimo = _númeroAuxiliar;

            return maiorFatorPrimo;
        }
    }
}
