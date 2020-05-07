using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace actividad
{
    class Program
    {
        private static void SaveDaata(Persona person)
        {
            Console.WriteLine("Nombre del archivo: ");
            string fileName = Console.ReadLine();
            // Creamos el Stream donde guardaremos nuestro juego
            FileStream fs = new FileStream(fileName, FileMode.CreateNew);

            Formatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, person);
            fs.Close();

        }
        static void Main(string[] args)
        {

            
        }
    }
}
