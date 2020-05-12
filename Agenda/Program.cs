using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            string[] nombre = new string[20];
            string[] dirección = new string[20];
            string[] correo = new string[20];
            int[] cel = new int[20];

            for (int i = 0; i < 20; i++) ;
            {
                Console.Write("Ingrese nombre: ");
                nombre[i] = Console.ReadLine();
                Console.Write("Ingrese la dirección: ");
                dirección[i] = Console.ReadLine();
                Console.Write("Ingrese correo: ");
                correo[i] = Console.ReadLine();
                Console.Write("Ingrese teléfono: ");
                line = Console.ReadLine();
                cel[i] = int.Parse();
            }
            for (int x = 0; i < 20; i++) ;
            {
                Console.WriteLine("nombre: " + nombre[x] + "dirección: " + dirección[x] + "correo: " + correo[x] + "teléfono: " + teléfono[x]);
            }
        }
    }
}
