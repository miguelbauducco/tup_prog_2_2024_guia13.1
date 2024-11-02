using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Agencia
    {
        private Queue<Denuncia> denuncias = new Queue<Denuncia>();
        private Queue<Cliente> nuevosClientes = new Queue<Cliente>();
        private List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        public List<Ticket> listaAtendidos = new List<Ticket>();

        public void AgregarTicket(Ticket turno) 
        {
            if(turno is Denuncia) 
            {
                denuncias.Enqueue(turno as Denuncia);
            }
            if (turno is Cliente) 
            {
                nuevosClientes.Enqueue(turno as Cliente);
            }
        }

        public Ticket AtenderTicket(int tipo) 
        {
            Ticket t = null;
            if(tipo == 0) 
            {
                if (denuncias.Count > 0) t = denuncias.Dequeue();
            }
            if (tipo == 1) 
            {
            if(nuevosClientes.Count > 0) t=nuevosClientes.Dequeue();  
            }
            if (t != null) listaAtendidos.Add(t);
            return t;
        }

        public Vehiculo BuscarVehiculo(string patente) 
        {
            listaVehiculos.Sort();

            int i = listaVehiculos.BinarySearch(new Vehiculo(patente,null));

            if (i >= 0)
            {
                return listaVehiculos[i];   
            }
            return null;
        }

        public void AgregarVehiculo(Vehiculo v) 
        {
            if (v != null) listaVehiculos.Add(v);
        }

    }
}
 