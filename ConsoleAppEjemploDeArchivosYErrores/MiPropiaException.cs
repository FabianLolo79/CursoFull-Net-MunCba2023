using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEjemploDeArchivosYErrores
{
    internal class MiPropiaException : Exception
    {
        public MiPropiaException()
        {
        }
        public MiPropiaException(string mensajeDeError) : base(mensajeDeError)
        {

        }
    }
}
