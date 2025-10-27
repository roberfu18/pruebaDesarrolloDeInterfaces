using System.Globalization;

namespace Ejercicio105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dias = { "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO", "DOMINGO" };
            double[] ventas = new double[6]; 

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Ingrese la venta del {dias[i]}:");
                string input = Console.ReadLine();
                ventas[i] = double.Parse(input);
            }

            // Mostrar lo que se guardó
            Console.WriteLine("Ventas registradas de martes a domingo:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{dias[i]}: {ventas[i]}");
            }


            double media_martes_viernes = 0;
            for (int i = 0; i < 5; i++)
            {
                media_martes_viernes += ventas[i];
            }

            if (media_martes_viernes < ventas[5])
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("SI");
            }

        }
    }
}
