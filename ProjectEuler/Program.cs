using System;
using ProjectEuler.Problem001SumOfMultiplesOf3Or5;
using ProjectEuler.Problema002SomaDeNúmerosParesFibonacci;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem001Resolution = new Problem001Resolution();
            var problem001Answer = problem001Resolution.SumOfAllTheMultiplesOf3Or5Below1000();

            Console.WriteLine($"Answer to Problem 001 = { problem001Answer }");

            var resoluçãoDoProblema002 = new ResoluçãoProblema002SomaDeNúmerosParesFibonacci();
            var respostaParaProblema002 = resoluçãoDoProblema002.SomaDosNúmerosParesFibonacciAté4Milhões();

            Console.WriteLine($"Resposta do Problema 002 = { respostaParaProblema002 }");
        }
    }
}
