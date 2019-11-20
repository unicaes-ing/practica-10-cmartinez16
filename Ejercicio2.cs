using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Practica_10
{
    public class Ejercicio2
    {
        static void Main(string[] args)
        {
            int opc;
            Console.Clear();
            Console.WriteLine("---------------Menú------------");
            Console.WriteLine(" 1. Agregar país");
            Console.WriteLine(" 2. Mostrar países");
            Console.WriteLine(" 3. Buscar pais");
            Console.WriteLine(" 4. Salir");
            Console.WriteLine("-------------------------------");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    
                    Console.Clear();
                    StreamWriter archivo = new StreamWriter("Arrg.txt", true);
                    string[] Paises;
                    int cantidad;
                    string nameP;
                    Console.Write("Escriba cuántos países desea agregar: ");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    Paises = new string[cantidad];
                    for (int i = 1; i <= cantidad; i++)
                    {
                        Console.Write("País: ");
                        nameP = Console.ReadLine();
                        archivo.WriteLine(nameP);
                    }

                    Console.Write("Presione <Enter> para salir");
                    archivo.Close();
                    Console.ReadKey();

                    break;

                case 2:
                    
                    string linea;
                    StreamReader mostrar = new StreamReader("Arreglo.txt");
                    Console.Clear();
                    linea = mostrar.ReadToEnd();
                    Console.Write(linea);
                    Console.Write("Presione <Enter> para salir");
                    mostrar.Close();
                    Console.ReadKey();

                    break;

                case 3:
                    
                    StreamReader mostrar2 = new StreamReader("Arreglo.txt");
                    string text;
                    string b;
                    Console.Clear();
                    Console.WriteLine("Ingrese el pais que desea buscar: ");
                    b = Console.ReadLine();
                    do
                    {
                        text = mostrar2.ReadLine();
                        if (text != null)
                        {
                            if (text.Equals(b))
                            {
                                Console.Clear();
                                Console.WriteLine("País encontado: ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(b);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("El país no se encuentra en la lista ");
                                Console.WriteLine("Presione <Enter> para salir");
                                Console.ReadKey();
                            }
                        }
                    } while (text != null);
                    Console.WriteLine("Presione <Enter> para continuar");
                    Console.ReadKey();

                    break;

                case 4:
                    
                    Console.Clear();
                    Console.WriteLine("Presione <Enter> para salir");
                    Console.ReadKey();
                    break;
            }
        }
    }
}