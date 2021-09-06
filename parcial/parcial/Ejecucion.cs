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


        private static void Leer()
        {
            Console.WriteLine("           ");
            Console.WriteLine("Seleccione el archivo que desea leer ");
            Console.WriteLine("1. Merary");
            Console.WriteLine("2. Audali");
            Console.WriteLine("3. Wilber");
            Console.WriteLine("4. Luis");
            Console.WriteLine("6. Salir");
            Console.Write("\nOpcion: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("SMIS072121" + "En este computo aprendi mucho, en especial en esta materia (progrmacion I)"
                        + "Mis conocimientos en programacion eran pocos, ahora con todo lo que me han enseñado puedo decir que,"
                        + "estoy satisfecha, ya que no solo obtuve nuevos conociemientos, tambien pude superar las dificultades"
                        + "ya que, en algunas tareas se me hizo un poco complicado, pero estar en la clase y buscar otros medios de informacion me ayudo mucho ");
                    break;
                case "2":
                    Console.WriteLine("En esta asignatura e podido apreder muchas nuevas, por ejemplo como manipular visual studio, usar git entre otrasa cosas, en algunas ocaciones e rtenido inconvenientes para enteder ciertos comandos pero gracias a la ingeniera e podido resolver muchas dudas ");

                    break;
                case "3":
                    Console.WriteLine("SMIS058221" + "Siento que una de las mayores dificultades en este parcial fue la creación de códigos y que estos funcionen correctamente ya que al no funcionar seria de crearlos nuevamente haciendo así el consumo de bastante tiempo realizando los nuevos códigos para que estos funcionen por eso siento que la creación de códigos fue lo mas complicado");
                    break;
                case "4":

                    Console.WriteLine("Un excelente curso profesional, entendí muchos conceptos que nunca entendí y otros códigos.");

                    break;

                case "5":

                default:
                    break;
            }
        }



    }



}







