using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prograll_Examen1_KGM
{
    static class Menu
    {
        public static void MenuPrincipal() 
        {
            char opcion = ' ';
            do
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("A- Vehículos ");
                Console.WriteLine("B- Ventas ");
                Console.WriteLine("C- Reportes");
                Console.WriteLine("D- Salir");
                Console.WriteLine("-------------------------------");
                Console.Write("Digite una opcion: ");
                opcion = char.Parse(Console.ReadLine().ToUpper());

                switch (opcion)
                {
                  /*  case 'A': Vehículos(subMenu()); break;
                    case 'B': Ventas(Submenu()); break;
                    case 'C': Reportes(); break;
                    case 'D': Salir(); break;
                    default:
                        Console.WriteLine("Opcion incorrecta!!");
                        break;*/
                }//Cierre de switch Menu

            } while (!opcion.Equals('D'));
        }

        public static void subMenu() 
        {
            char opcion = ' ';
            do
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1- Agregar ");
                Console.WriteLine("2- Modificar ");
                Console.WriteLine("3- Consultar");
                Console.WriteLine("4- Salir");
                Console.WriteLine("-------------------------------");
                Console.Write("Digite una opcion: ");
                opcion = char.Parse(Console.ReadLine().ToUpper());

                switch (opcion)
                {
                      case 'A': Vehículos.AgregarVehículos(); break;
                    /*  case 'B': Modificar(); break;
                      case 'C': Consultar(); break;
                     /* case 'D': Salir(); break;
                      default:
                          Console.WriteLine("Opcion incorrecta!!");
                          break;*/
                }//Cierre de switch Menu

            } while (!opcion.Equals('4'));
        }
    }//Cierre de class
}//Ciere de namespace
