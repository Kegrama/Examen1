using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prograll_Examen1_KGM
{

    class Vehículos
    { 
        static int[] Codigo = new int[5];
        static string[] Marca = new string[5];
        static int [] Costo = new int[5];
        static string[] Modelo = new string[5];
        static byte indice;

        public Vehículos() { }

       /* private int[] Codigo { get; set; }
        private string[] Marca { get; set; }
        private int[] Costo { get; set; }
        private string[] Modelo { get; set; }*/

        public Vehículos(int[] codigoV, string[] marcaV, int[] costoV, string[] modeloV) 
        {
            Codigo = codigoV;
            Marca = marcaV;
            Costo = costoV;
            Modelo = modeloV;   
            
        }//Cierre de Vehículos

        private static int solicitarCodigo()
        {
            Console.WriteLine("Ingrese el código del ehículo");
            int numcod = int.Parse(Console.ReadLine());

            return numcod;
        }//Cierre de SolicitarCódigo


        public static void AgregarVehículos() 
        {
            char opcion = ' ';

            do
            {
                Console.WriteLine("Ingrese el código del vehículo.");
                Codigo[indice] = int.Parse(Console.ReadLine());

                Console.WriteLine("Marca del vehículo: ");
                Marca[indice] = Console.ReadLine();

                Console.WriteLine("Costo del vehículo");
                Costo[indice] = int.Parse(Console.ReadLine());

                Console.WriteLine("Modelo y año del vehículo ");
                Modelo[indice] = Console.ReadLine();


                indice++;

                Console.WriteLine("¿Desea agregar otro vehículo? 1-Si 2-No");
                opcion = Convert.ToChar(Console.ReadLine());

            } while (!opcion.Equals('2'));

        }//Cierre de agregar vehículos

        public void modificarVehiculo(int numcod) 
        {
            int i = 0;

            char opcion = ' ';

            do
            {
                Console.WriteLine("Ingrese el nuevo código del vehículo.");
                Codigo[indice] = int.Parse(Console.ReadLine());

                while ((i <= indice) && (!numcod.Equals(Codigo[i])))
                {
                    i++;
                }

                Console.WriteLine("Marca del vehículo: ");
                Marca[indice] = Console.ReadLine();

                Console.WriteLine("Costo del vehículo");
                Costo[indice] = int.Parse(Console.ReadLine());

                Console.WriteLine("Modelo y año del vehículo ");
                Modelo[indice] = Console.ReadLine();

                indice++;

                Console.WriteLine("¿Desea modificar otro vehículo? 1-Si 2-No");
                opcion = Convert.ToChar(Console.ReadLine());

            } while (!opcion.Equals('2'));

            Console.WriteLine("El vehpiculo se ha modificado correctamente");

        }//Cierre de modificarVehículo

        public void consultarArtículos(int numcod) 
        {
      
        }//Cierre de consultarArtículo
           
    }//Cierre de class

}//Cierre de namespace
