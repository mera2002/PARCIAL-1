using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Libreria
{
    public class Class1
    {
    }


    static void Iniciarsesion()
    {

        Console.Write("Usuario : ");
        var name = Console.ReadLine();
        Console.Write("Contraseña : ");
        int newAge = Convert.ToInt32(Console.ReadLine());



        if (name == "adm")


        {
            Console.WriteLine("                ");
            Console.WriteLine("Bienvenido al usuario admnistrador");
            Console.WriteLine("                ");
            Console.WriteLine("1. Registrar nuevo usuario ");
            Console.WriteLine("2. crear archivos ");
            Console.WriteLine("3. Borrar archivos  ");
            Console.WriteLine("4. Salir");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    registrarse();
                    break;
                case "2":
                    Console.WriteLine("Los archivos se generaon con exito ");
                    break;
                case "3":

                    break;

                case "4":
                    break;
                default:
                    break;
            }

        }
        else
        {
            Console.WriteLine("BIENVENIDOS!");
            Console.WriteLine("                ");
            Console.WriteLine("1. Leer archivos ");
            Console.WriteLine("2. Salir");
            Console.Write("\nOpcion: ");
            string input = Console.ReadLine();
            switch (input)
            {

                case "1":

                    break;


                case "2":
                    break;
                default:
                    break;
            }

        }

        Dictionary<object, object> temp = new Dictionary<object, object>();
        temp = readFile();

        {