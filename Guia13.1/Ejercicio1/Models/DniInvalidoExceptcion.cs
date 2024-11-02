using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class DniInvalidoException:ApplicationException
    {
        public DniInvalidoException() : base ("Dni invalido") { }
        public DniInvalidoException(string message) : base(message) { }
        public DniInvalidoException(string msg, Exception ex) : base(msg, ex) { }
    }
}
