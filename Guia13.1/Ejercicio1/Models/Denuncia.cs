using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Denuncia : Ticket
    {
        private Vehiculo dominio;
        private static int numero;

        public Denuncia(Vehiculo asegurado)
        {
            dominio = asegurado;
            nroOrden = numero++;
        }
    }
}
