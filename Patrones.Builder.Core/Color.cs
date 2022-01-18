using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Builder.Core
{
    public abstract class Color
    {
        protected string _descripcion;
        //en esta vriable va a retornar la descripcion del color 
        public string Descripcion { get { return _descripcion; } }
    }
    public class Verde : Color
    {
        public Verde()
        {
            _descripcion = "El personaje de color verde";
        }
    }
    public class Dorado : Color
    {
        public Dorado()
        {
            _descripcion = "El personaje de color dorado";
        }
    }
    public class Azul : Color
    {
        public Azul()
        {
            _descripcion = "El personaje de color azul";
        }
    }

}
