using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Libreria;

namespace parcial
{
    class Program
    {
        static void main(string[] args)
        {




            string path = (@"C:\PARCIAL1\Libreria\registro.text");


            using (StreamWriter archivo = File.AppendText(path))
            {

                archivo.WriteLine("REGISTRO E INICIO DE SESION");



                string archivo1 = (@"C:\PARCIAL1\Libreria\Merary.text");

                using (StreamWriter Merary = File.AppendText(archivo1))
                {

                    Merary.WriteLine("En este computo aprendi mucho, en especial en esta materia (progrmacion I)" 
                        + "Mis conocimientos en programacion eran pocos, ahora con todo lo que me han enseñado puedo decir que,"
                        + "estoy satisfecha, ya que no solo obtuve nuevos conociemientos, tambien pude superar las dificultades" 
                        + "ya que, en algunas tareas se me hizo un poco complicado, pero estar en la clase y buscar otros medios de informacion me ayudo mucho ");
                }
                string archivo2 = (@"C:\PARCIAL1\Libreria\Audali.text");

                using (StreamWriter Audali = File.AppendText(archivo2))
                {
                    Audali.WriteLine("En esta asignatura e podido apreder muchas nuevas, por ejemplo como manipular visual studio, usar git entre otrasa cosas, en algunas ocaciones e rtenido inconvenientes para enteder ciertos comandos pero gracias a la ingeniera e podido resolver muchas dudas ");

                }
                string archivo3 = (@"C:\PARCIAL1\Libreria\Wilber.text");

                using (StreamWriter Wilber = File.AppendText(archivo3))
                {
                    Wilber.WriteLine("Siento que una de las mayores dificultades en este parcial fue la creación de códigos y que estos funcionen correctamente ya que al no funcionar seria de crearlos nuevamente haciendo así el consumo de bastante tiempo realizando los nuevos códigos para que estos funcionen por eso siento que la creación de códigos fue lo mas complicado");
                }
                string archivo4 = (@"C:\PARCIAL1\Libreria\Luis.text");

                using (StreamWriter Luis = File.AppendText(archivo4))
                {
                    Luis.WriteLine("");
                }

            }


            Console.ReadKey();
        }

    }
}



