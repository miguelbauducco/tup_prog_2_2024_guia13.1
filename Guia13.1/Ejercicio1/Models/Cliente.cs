using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Cliente:Ticket
    {
        private long dni { get; set; }

        private static int numero;

        public Cliente(long dni)
        {
            if(dni > 5000000 ) 
            {
                this.dni = dni;
            }
            else
            {
                throw new DniInvalidoException();
            }
            nroOrden = numero++;
        }

    }
}
