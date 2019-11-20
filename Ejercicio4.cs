using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
    public class Ejercicio4
    {
        static void Main(string[] args)
        {
            string us, contr, p;
            int user = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("----------Inicio de sesión---------");
                Console.Write("Username: ");
                us = Console.ReadLine();
                Console.Write("Password: ");
                contr = Console.ReadLine();
                p = us + ":" + contr;
                Console.ResetColor();
                if (V(p) == true)
                {
                    Console.WriteLine("Contraseña correcta");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");
                    Console.WriteLine("Intentelo de nuevo");
                    Console.ReadKey();
                    user++;
                }
            } while (user != 3);
            if (user == 3)
            {
                Console.WriteLine("Inicio de sesión bloqueado");
                Console.ReadLine();
            }
        }
        static bool V(string key)
        {
            string datos;
            bool correct = false;
            StreamReader b = new StreamReader("Usuarios.txt");
            do
            {
                datos = b.ReadLine();
                if (datos == key)
                {
                    correct = true;
                }
            } while (datos != null);
            return correct;
        }
    }

}
