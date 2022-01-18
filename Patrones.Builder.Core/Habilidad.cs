using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Builder.Core
{
    public abstract class Habilidad
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }
    public class Fuerza : Habilidad
    {
        public Fuerza()
        {
            _descripcion = "Habilidad de Fuerza";
        }
    }
    public class Inmunidad : Habilidad
    {
        public Inmunidad()
        {
            _descripcion = "Habilidad de Inmunidad";
        }
    }
    public class Velocidad : Habilidad
    {
        public Velocidad()
        {
            _descripcion = "Habilidad de Velocidad";
        }
    }

}
