using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Contacto
    {
        // auto properties 
        public string Nombre { get; set; }
        public string Dirrecion { get; set; }
        public string TelefonoCasa { get; set; }
        public string CorreoElectronico { get; set; }

        //Properties
        private string _telefonocelular;
        public string TelefonoCelular
        {
            get {
                return _telefonocelular;
            }
            set {
                if (value.Length == 10)
                {
                    _telefonocelular = value;

                }
                else if (value.Length == 7)
                {
                    _telefonocelular = "644" + value;
                }else
                {
                    Console.WriteLine("Introduce un numero de celular valido");
                }
                
               
            }
        }
    }
}
