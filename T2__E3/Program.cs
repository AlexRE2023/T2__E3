using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2__E3
{
    internal class Program

    {

        static void Main(string[] args)

        {

            int opcion = menu();

            do

            {

                switch (opcion)

                {

                    case 1:

                        opcion = suma();

                        break;

                    case 2:

                        opcion = resta();

                        break;

                    case 3:

                        opcion = multiplicacion();

                        break;

                    case 4:

                        opcion = division();

                        break;

                }



            } while (opcion != 5);

        }

        public static int menu()

        {

            Console.Clear();

            Console.WriteLine("======================\n" +

              "Las cuatro operaciones\n" +

              "=======================\n" +

              "1. Suma\n" +

              "2. Resta\n" +

              "3. Multiplicaión\n" +

              "4. División\n" +

              "5. Salir\n" +

              "Ingrese una opción: ");

            return getOpcion();

        }



        public static int suma()

        {

            Console.Clear();

            Console.WriteLine("=========================\n" +

              "Sumando..\n" +

              "=========================\n");

            Console.Write("número 1: ");

            int numero1 = getNumero();

            Console.Write("número 2: ");

            int numero2 = getNumero();

            int resultado = numero1 + numero2;



            Console.WriteLine("=============\n" +

              "Resultado: " + resultado + "\n" +

              "1: Limpiar | 2: Regresar al menú \n" +

              "Ingrese una opción: \n");



            int opcion = getOpcion();

            if (opcion == 1)

            {

                return suma();

            }

            if (opcion == 2)

            {

                return menu();

            }

            return opcion;





        }

        public static int resta()

        {

            Console.Clear();

            Console.WriteLine("==============================\n" +

              "Restando..\n" +

              "=========================\n");

            Console.WriteLine("número 1: ");

            int numero1 = getNumero();

            Console.WriteLine("número 2: ");

            int numero2 = getNumero();

            int resultado = numero1 - numero2;



            Console.WriteLine("=============\n" +

              "Resultado: " + resultado + "\n" +

              "1: Limpiar | 2: Regresar al menú \n" +

              "Ingrese una opción: \n");



            int opcion = getOpcion();

            if (opcion == 1)

            {

                return resta();

            }

            if (opcion == 2)

            {

                return menu();

            }

            return opcion;



        }

        public static int multiplicacion()

        {

            Console.Clear();

            Console.WriteLine("==============================\n" +

              "Multiplicando..\n" +

              "=========================\n");

            Console.WriteLine("número 1: ");

            int numero1 = getNumero();

            Console.WriteLine("número 2: ");

            int numero2 = getNumero();

            int resultado = numero1 * numero2;



            Console.WriteLine("=============\n" +

              "Resultado: " + resultado + "\n" +

              "1: Limpiar | 2: Regresar al menú \n" +

              "Ingrese una opción: \n");



            int opcion = getOpcion();

            if (opcion == 1)

            {

                return multiplicacion();

            }

            if (opcion == 2)

            {

                return menu();

            }

            return opcion;



        }

        public static int division()

        {

            Console.Clear();

            Console.WriteLine("==============================\n" +

              "Multiplicando..\n" +

              "=========================\n");

            Console.WriteLine("número 1: ");

            int numero1 = getNumero();

            Console.WriteLine("número 2: ");

            int numero2 = getNumero();

            int resultado = numero1 / numero2;



            Console.WriteLine("=============\n" +

              "Resultado: " + resultado + "\n" +

              "1: Limpiar | 2: Regresar al menú \n" +

              "Ingrese una opción: \n");



            int opcion = getOpcion();

            if (opcion == 1)

            {

                return division();

            }

            if (opcion == 2)

            {

                return menu();

            }

            return opcion;

        }

        public static int getOpcion()

        {

            string opcionTexto = Console.ReadLine();

            return int.Parse(opcionTexto);

        }

        public static int getNumero()

        {

            string numeroTexto = Console.ReadLine();

            return int.Parse(numeroTexto);

        }



    }
}
