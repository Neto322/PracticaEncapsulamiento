using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            // We created a contact instance
            Contacto contactouno = new Contacto();
            contactouno.Nombre = "Mauricio";
            contactouno.Dirrecion = "Enrique Segoviano";
            contactouno.CorreoElectronico = "MauricioTatemada@jotmeil.com.mx.edu.gob";
            contactouno.TelefonoCasa = "233253445";
            contactouno.TelefonoCelular = "";

            Console.WriteLine("Nombre:" + contactouno.Nombre);

            Console.WriteLine("Dirrecion:" + contactouno.Dirrecion);

            Console.WriteLine("Correo:" + contactouno.CorreoElectronico);

            Console.WriteLine("Telefono Casa:" + contactouno.TelefonoCasa);

            Console.WriteLine("Telefono Cel:" + contactouno.TelefonoCelular);

            Console.ReadLine();
            
        }
    }
}
