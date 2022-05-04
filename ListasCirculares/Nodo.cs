using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    public class Nodo
    { 
        public string Siguiente { get; set; }
        public Nodo Enlace { get; set; }
        public Nodo(string siguiente = "", Nodo enlace = null)
        {
            Siguiente = siguiente;
            Enlace = enlace;
        }
    }
}
