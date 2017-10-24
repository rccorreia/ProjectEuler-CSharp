using System;
using System.Collections.Generic;

namespace ProjectEuler.Problema002SomaDeNúmerosParesFibonacci
{
    public class Fibonacci
    {
        public List<int> NúmerosDeFibonacciMenoresOuIguaisAoNúmeroMáximo(int númeroMáximo)
        {
            var númeroAtual = 1;
            var númeroAnterior = 1;
            var auxiliar = 0;
            var númerosDeFibonacci = new List<int>();

            while(númeroAtual <= númeroMáximo)
            {
                númerosDeFibonacci.Add(númeroAtual);

                auxiliar = númeroAtual;
                númeroAtual += númeroAnterior;
                númeroAnterior = auxiliar;
            }

            return númerosDeFibonacci;
        }
    }
}
