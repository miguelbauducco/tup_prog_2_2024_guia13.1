using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Ticket
    {
        protected int nroOrden;
        private DateTime fechaHora = DateTime.Now;

        public int VerNro() 
        {
            return nroOrden; 
        }

        public DateTime FechaHora() 
        { 
            return fechaHora; 
        }


    }
}
