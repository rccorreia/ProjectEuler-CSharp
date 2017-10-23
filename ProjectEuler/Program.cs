using System;
using ProjectEuler.Problema_001_SomaDeMúltiplosDe_3_Ou_5;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var resoluçãoDoProblema_001 = new ResoluçãoProblema_001_SomaDeMúltiplosDe_3_Ou_5();
            var respostaParaProblema_001 = resoluçãoDoProblema_001.SomaDosMúltiplosDe_3_Ou_5_Entre_0_E_999();

            Console.WriteLine($"Resposta do Problema 001 = { respostaParaProblema_001 }");
        }
    }
}
