using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Practica_10
{
    public class Ejercicio3
    {
        static void Main(string[] args)
        {
            int opc;

            Console.Clear();
            Console.WriteLine("------------Menú------------");
            Console.WriteLine(" 1. Ingresar");
            Console.WriteLine(" 2. Salir");
            Console.WriteLine("---------------------------");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    
                    StreamWriter registro = new StreamWriter("Usuarios.txt", true);
                    string user, password, verificar;
                    Console.Clear();
                    Console.Write("Username: ");
                    user = Console.ReadLine();
                    Console.WriteLine("Usuario registrado");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Username: {0}", user);
                    Console.Write("Password: ");
                    password = Console.ReadLine();
                    Console.ResetColor();
                    if (password.Length < 7 || password.Length > 20)
                    {
                        Console.Write(" La contraseña debe tener más de 7 caracteres");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Username: {0}", user);

                        Console.Write(" Confirme su password: ");
                        verificar = Console.ReadLine();
                        Console.ResetColor();
                        if (verificar.Equals(password))
                        {
                            Console.WriteLine("Contraseña confirmada ");
                            registro.Close();
                            Console.ReadKey();
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.Write(" Las contraseñas no coinciden");
                            Console.Clear();
                            Console.ReadKey();
                        }
                    }

                    break;

                case 2:
                    
                    Console.Clear();
                    Console.WriteLine("Presione <Enter> para salir");
                    Console.ReadKey();

                    break;
            }
        }
    }
}
