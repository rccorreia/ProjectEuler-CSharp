using System;
using ProjectEuler.Problema001SomaDeMúltiplosDe3Ou5;
using ProjectEuler.Problema002SomaDeNúmerosParesFibonacci;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var resoluçãoDoProblema001 = new ResoluçãoProblema001SomaDeMúltiplosDe3Ou5();
            var respostaParaProblema001 = resoluçãoDoProblema001.SomaDosMúltiplosDe3Ou5NoPeríodo();

            Console.WriteLine($"Resposta do Problema 001 = { respostaParaProblema001 }");

            var resoluçãoDoProblema002 = new ResoluçãoProblema002SomaDeNúmerosParesFibonacci();
            var respostaParaProblema002 = resoluçãoDoProblema002.SomaDosNúmerosParesFibonacciAté4Milhões();

            Console.WriteLine($"Resposta do Problema 002 = { respostaParaProblema002 }");
        }
    }
}
