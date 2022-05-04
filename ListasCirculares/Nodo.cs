using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    public class Nodo
    {
        public string Dato 
        { get { return Dato; }
          set { Dato = value; } 
        }
        public Nodo Siguiente 
        { get { return Siguiente; } 
          set { Siguiente = value; } 
        }
    }
}
