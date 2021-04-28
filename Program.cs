using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado;
            Console.Write("Digite um número para contruir sua tabuada: ");
            numero=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++){
                resultado=numero*i;
                Console.WriteLine(resultado);
            }
        }
    }
}
