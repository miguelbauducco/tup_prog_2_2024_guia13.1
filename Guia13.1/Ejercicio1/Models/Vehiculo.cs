using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Vehiculo:IComparable<Vehiculo>
    {
        private string nroPatente;
        private Cliente dueño;

        public Vehiculo(string patente, Cliente dueño) 
        {
            nroPatente = patente;
            this.dueño = dueño;
        }

        public int CompareTo(Vehiculo v)
        {
            if (v != null) 
            {
                return nroPatente.CompareTo(v.nroPatente);
            }
            return -1; 
        }

        public Cliente VerDueño() 
        {
            return dueño;
        }

        public string VerPatente()
        {
            return nroPatente.ToString();
        }



    }
}
