using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Practica_10
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                int opc;


                Console.Clear();
                Console.WriteLine("----------Menú------------");
                Console.WriteLine(" 1. Agregar país");
                Console.WriteLine(" 2. Mostrar países");
                Console.WriteLine(" 3. Buscar pais");
                Console.WriteLine(" 4. Salir");
                Console.WriteLine("--------------------------");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:

                        Console.Clear();
                        StreamWriter archivo = new StreamWriter("PaisesAgregados.txt", true);
                        string nameP;
                        Console.Write("Escriba el país: ");
                        nameP = Console.ReadLine();
                        archivo.WriteLine(nameP);
                        Console.Write("Presione <Enter> para salir");
                        archivo.Close();
                        Console.ReadKey();

                        break;

                    case 2:

                        string linea;
                        StreamReader mostrar = new StreamReader("PaisesAgregados.txt");
                        Console.Clear();
                        linea = mostrar.ReadToEnd();
                        Console.Write(linea);
                        Console.Write("Presione <Enter> para salir");
                        mostrar.Close();
                        Console.ReadKey();

                        break;

                    case 3:

                        StreamReader mostrar2 = new StreamReader("Paises.txt");
                        string text;
                        string b;
                        Console.Clear();
                        Console.WriteLine("Escriba el pais que desea buscar: ");
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
                                    Console.Write("El pais no se encuentra en la lista");
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
}
