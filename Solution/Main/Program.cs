using System;
using Dll;


namespace Main
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero: ");
            int primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese operador");
            var operador =Console.ReadLine();

            Console.WriteLine("Ingrese numero");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            var operacion = ObtenerFabrica.ConfiguracionFabrica(operador);

            Console.WriteLine("El resultado : " + operacion.Resultado(primerNumero,segundoNumero));
            Console.ReadKey();
        }
    }
}