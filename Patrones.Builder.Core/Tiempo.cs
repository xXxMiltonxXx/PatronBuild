using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Builder.Core
{
    public abstract class Tiempo
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }
    public class Segundos3 : Tiempo
    {
        public Segundos3()
        {
            _descripcion = "tres segundos";
        }
    }
    public class Segundos5 : Tiempo
    {
        public Segundos5()
        {
            _descripcion = "cinco segundos";
        }
    }
    public class Segundos8 : Tiempo
    {
        public Segundos8()
        {
            _descripcion = "ocho segundos";
        }
    }

}
