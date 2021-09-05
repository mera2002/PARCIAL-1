using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace parcial
{
    class Ejecucion
    {
        static void Main()
        {
            bool showMenu = true;

            while (showMenu)
            {
                showMenu = Menu();
            }
            Console.ReadKey();
        }

        private static bool Menu()
        {
         
            Console.WriteLine("BIENVENIDOS: ");
            Console.WriteLine("                ");

            Console.WriteLine("1. Iniciar seseion");
            Console.WriteLine("2. Salir");
            Console.Write("\nOpcion: ");

            switch (Console.ReadLine())
            {

                case "1":
                    Iniciarsesion();
                    Console.ReadKey();
                    return true;

                case "2":
                    return false;
                default:
                    return false;
            }
        }

        private static string getPath()
        {
            string path = (@"C:\PARCIAL1\Libreria\registro.text");
            return path;
        }

        private static void registrarse()
        {
            Console.Write("Usuario: ");
            string fullname = Console.ReadLine();
            Console.Write("Contraseña: ");
            int age = Convert.ToInt32(Console.ReadLine());

  
            if (search(fullname))
            {
                Console.WriteLine("Este registro ya existe, ingrese un usuario nuevo");
            }
            else
            {

                using (StreamWriter regis = File.AppendText(getPath()))
                {
                    regis.WriteLine("{0}; {1}", fullname, age);
                    regis.Close();
                }
            }

        }

        private static Dictionary<object, object> readFile()
        {
            Dictionary<object, object> listData = new Dictionary<object, object>();

            using (var reader = new StreamReader(getPath()))
            {
                string lines;

                while ((lines = reader.ReadLine()) != null) 
                {
                    string[] keyvalue = lines.Split(';');
                    if (keyvalue.Length == 2)
                    {
                        listData.Add(keyvalue[0], keyvalue[1]);
                    }
                }

            }

            return listData;
        }

        private static bool search(string name)
        {
            if (!readFile().ContainsKey(name))
            {
                return false;
            }
            return true;
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






            }
        }
    }
}






    
