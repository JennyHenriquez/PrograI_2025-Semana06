using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsodeClases.Modelos;

namespace UsodeClases
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Instalar la clase Persona, en otras palabras crear un objeto
            
            //Crear el objeto "persona1"
            Persona persona1 = new Persona("Mario", "Alvarenga", 19, DateTime.Parse("2007/05/02"), "06223410-5", "7023-0000", "San Salvador, Centro", "marioalvarengagmail.com");
            //Mostrar datos del objeto persona1
            Console.WriteLine(persona1.ToString());

            //Crear objeto ""persona2"
            Persona persona2 = new Persona("Marta", "Guillen", 45, DateTime.Parse("1980/04/06"), "09873456-6", "7677-0480", "Chalatenango, Centro", "martaguillengmail.com");
            //Mostrar datos del objeto persona2
            Console.WriteLine(persona2.ToString());

            Console.ReadLine();
        }
    }
}
