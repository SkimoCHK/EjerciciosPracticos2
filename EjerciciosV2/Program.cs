using System;

namespace EjerciciosV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clases.Ejercicios ejercicios = new Clases.Ejercicios();

            Console.WriteLine("Escoga el problema que desea resolver (1-5):");
            int problema = Convert.ToInt32(Console.ReadLine());

            switch (problema)
            {
                case 1:
                    ejercicios.SumaArreglos();
                    break;
                case 2:
                    ejercicios.BuscarElemento();
                    break;
                case 3:
                    Console.WriteLine("Ingrese la cantidad de alumnos para Álgebra:");
                    int cantidadAlgebra = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad de alumnos para Análisis:");
                    int cantidadAnalisis = Convert.ToInt32(Console.ReadLine());
                    ejercicios.AlumnosClases(cantidadAlgebra, cantidadAnalisis);
                    break;
                case 4:
                    Console.WriteLine("Ingrese la longitud del arreglo:");
                    int longitudArreglo = Convert.ToInt32(Console.ReadLine());
                    ejercicios.ArregloNoRepetido(longitudArreglo);
                    break;
                case 5:
                    ejercicios.PromedioNotas();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            
        }
    }
}
