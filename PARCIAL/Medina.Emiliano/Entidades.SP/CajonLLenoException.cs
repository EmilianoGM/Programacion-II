using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    public class CajonLLenoException : Exception
    {
        public CajonLLenoException() : base("Capacidad maxima de cajon alcanzada") { }
    }
}
