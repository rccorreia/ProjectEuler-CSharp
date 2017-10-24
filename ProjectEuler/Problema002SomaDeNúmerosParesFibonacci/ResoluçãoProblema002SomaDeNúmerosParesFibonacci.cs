namespace ProjectEuler.Problema002SomaDeNúmerosParesFibonacci
{
    public class ResoluçãoProblema002SomaDeNúmerosParesFibonacci
    {
        public int SomaDosNúmerosParesFibonacciAté4Milhões()
        {
            var fibonacci = new Fibonacci();
            var operaçõesMatemáticas = new OperaçõesMatemáticas();

            var númerosDeFibonacciAté4Milhões = fibonacci.NúmerosDeFibonacciMenoresOuIguaisAoNúmeroMáximo(4000000);

            return operaçõesMatemáticas.SomaDeNúmerosParesDeUmaLista(númerosDeFibonacciAté4Milhões);
        }
    }
}
