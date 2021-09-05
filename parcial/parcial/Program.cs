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
             
        }
          

                   Console.ReadKey();
        }

}
}



