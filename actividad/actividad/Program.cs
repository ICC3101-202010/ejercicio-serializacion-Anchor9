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
        private static void SaveData(Persona person)
        {
            Console.WriteLine("Nombre del archivo: ");
            string fileName = Console.ReadLine();
            // Creamos el Stream donde guardaremos nuestro juego
            FileStream fs = new FileStream(fileName, FileMode.CreateNew);

            Formatter formatter = new BinaryFormatter()
            //no entiendoi por que me tira error el binary formatter
            formatter.Serialize(fs, person);
            fs.Close();

        }
        private static Persona Loaddata()
        {
            Console.WriteLine("Nombre del archivo: ");
            string fileName = Console.ReadLine();
             // Creamos el Stream donde se encuentra nuestro juego
            FileStream fs = new FileStream(fileName, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            Persona person = formatter.Deserialize(fs) as Persona;
            fs.Close();
            return person;
        }
        static void Main(string[] args)
        {
            Persona p1 = new Persona();

            SaveData(p1);
            Loaddata();
            
        }
    }
}
