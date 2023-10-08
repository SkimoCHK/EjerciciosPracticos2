using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosV2.Clases
{
    public class Ejercicios
    {

        public void SumaArreglos()
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] total = new int[5];

            Console.WriteLine("Ingrese los valores para el primer arreglo");
            for (int x = 0; x < 5; x++)
            {

                Console.WriteLine($"Ingrese el valor de la posición {x} del arreglo1 ");
                array1[x] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Ingrese el valor de la posición {x} del arreglo2");
                array2[x] = Convert.ToInt32(Console.ReadLine());

                total[x] = array1[x] + array2[x];

            }

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine($"valor en la posición {x} del arreglo1 + valor en la posicion{x} del arreglo 2 = {total[x]} en la posición {x} del arreglo3");
            }



        }
        public void BuscarElemento()
        {
            Console.WriteLine("Ingresa un nombre pa ver si existe en la base de datos");
            string nombre = Console.ReadLine();

            string[] nombresArreglo = { "Juan", "Carlos", "Pedro", "Carlos", "Alex" };
            int[] copia = new int[nombresArreglo.Length];
            int contador = 0;

            for (int x = 0; x < nombresArreglo.Length; x++)
            {
                if (nombre == nombresArreglo[x])
                {

                    copia[contador] = x;
                    contador++;


                }

            }
            Console.WriteLine($"Hay {contador} coincidencias");
            for (int x = 0; x < contador; x++)
            {
                Console.WriteLine($"Las posiciones son {copia[x]}");
            }

        }
        public void AlumnosClases(int cantidad, int cantidad2)
        {
            int[] AlgebraIDS = new int[cantidad];
            int[] AnalisisIDS = new int[cantidad2];
            int[] TotalAlumnos = new int[cantidad + cantidad2];

            Console.WriteLine("Por favor, digame los ID'S de los alumnos de Algebra");
            for (int x = 0; x < AlgebraIDS.Length; x++)
            {
                Console.WriteLine($"Ahora, escriba el ID del alumno {x + 1} en su lista de alumnos de Algebra");
                AlgebraIDS[x] = Convert.ToInt32(Console.ReadLine());
                TotalAlumnos[x] = AlgebraIDS[x];

            }
            Console.WriteLine("Por favor, digame los ID'S de los alumnos de Analisis");
            for (int x = 0; x < AnalisisIDS.Length; x++)
            {
                Console.WriteLine($"Ahora, escriba el ID del alumno {x + 1} en su lista de alumnos de Analisis");
                AnalisisIDS[x] = Convert.ToInt32(Console.ReadLine());
                TotalAlumnos[AlgebraIDS.Length + x] = AnalisisIDS[x];

            }
            Console.WriteLine($"El total de ID'S de alumnos registrados es: {TotalAlumnos.Length}");
            Console.WriteLine("A continuacion se muestran los ID'S  de los alumnos....");
            for (int x = 0; x < TotalAlumnos.Length; x++)
            {
                Console.WriteLine(TotalAlumnos[x]);


            }
            int contador = 0;
            for (int x = 0; x < TotalAlumnos.Length; x++)
            {
                for (int y = x + 1; y < TotalAlumnos.Length; y++)
                {
                    if (TotalAlumnos[x] == TotalAlumnos[y])
                    {
                        contador++;
                        break;
                    }
                }
            }
            Console.WriteLine($"El total de alumnos repetidos en ambas clases es {contador} ");





        }


        public void ArregloNoRepetido(int longitud)
        {
            int[]arregloxd = new int[longitud];
            int comparador = longitud;
            Console.WriteLine("Por favor, ingresa valores pa el arreglo pero sin repetirse");
            Console.WriteLine("Ingresa el primer valor");
            arregloxd[0] = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            int p = 0;
            
                while(x < arregloxd.Length && p < arregloxd.Length)
                {
                Console.WriteLine($"Ingresa el valor {x+1} del arreglo");
                    arregloxd[x] = Convert.ToInt32(Console.ReadLine());
                    
                    for (int y = 0; y < x; y++)
                    {
                        if (arregloxd[x] == arregloxd[y])
                        {
                            Console.WriteLine("No puede ingresar valores repetidos, por favor intente de nuevo");
                            p = 999;

                        }
                        else
                        {

                        }

                    }
                    
                    x++;


                }

            if (x <= arregloxd.Length && p < arregloxd.Length)
            {
                Console.WriteLine("Los numeros ingresados por el usuario son ");
                for (int z = 0; z < arregloxd.Length; z++)
                {
                    Console.WriteLine($"Valor {z + 1} = {arregloxd[z]}");
                }
            }
            else
            {

            }
           

        }

        public void PromedioNotas()
        {
            int[] notas = new int[8];
            float aprobados = 0;
            float promedioA = 0;
            float promedioR = 0;
            float reprobados = 0;
            Console.WriteLine("Por favor, ingrese la nota de cada alumno en su lista");

            for(int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Ingrese la nota del alumno numero {i+1} de su lista de alumnado ");
                notas[i] = Convert.ToInt32(Console.ReadLine());

                if (notas[i] > 6)
                {
                    aprobados++;
                    promedioA += notas[i];

                }
                else
                {
                    reprobados++;
                    promedioR += notas[i];
                }


            }

            promedioA = promedioA / aprobados;
            promedioR = promedioR / reprobados;

            if(promedioA < 6)
            {
                Console.WriteLine($"Cantidad de aprobados: {aprobados}");
                Console.WriteLine($"Cantidad de reprobados: {reprobados}\n");
                Console.WriteLine($"Promedio de aprobados: {promedioA}");
                Console.WriteLine($"Promedio de reprobados: {promedioR}\n");
                Console.WriteLine("Rango: Deficiente");
            }
            if (promedioA > 6 && promedioA < 11)
            {
                Console.WriteLine($"Cantidad de aprobados: {aprobados}");
                Console.WriteLine($"Cantidad de reprobados: {reprobados}\n");
                Console.WriteLine($"Promedio de aprobados: {promedioA}");
                Console.WriteLine($"Promedio de reprobados: {promedioR} \n");
                Console.WriteLine("Rango: Regulares");
            }
            if (promedioA > 11 && promedioA < 16)
            {
                Console.WriteLine($"Cantidad de aprobados: {aprobados}");
                Console.WriteLine($"Cantidad de reprobados: {reprobados}\n");
                Console.WriteLine($"Promedio de aprobados: {promedioA}");
                Console.WriteLine($"Promedio de reprobados: {promedioR}");
                Console.WriteLine("Rango: Buenos");
            }
            if (promedioA > 16)
            {
                Console.WriteLine($"Cantidad de aprobados: {aprobados}");
                Console.WriteLine($"Cantidad de reprobados: {reprobados}\n");
                Console.WriteLine($"Promedio de aprobados: {promedioA}");
                Console.WriteLine($"Promedio de reprobados: {promedioR}\n");
                Console.WriteLine("Rango: Excelente");
            }






        }



    }
}
