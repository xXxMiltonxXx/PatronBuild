using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Builder.Core
{
    public abstract class PersonajeConstructor
    {
        //operaciones que va a realizar
        //que tipo de habilidad, tiempo, color va a generar las Acciones
        protected string _descripcion;
        public abstract Habilidad ConstructorHabilidad();
        public abstract Tiempo ConstructorTiempo();
        public abstract Color ConstructorColor();
        public override string ToString()
        {
            return _descripcion;
        }
        //generar una Habilidad,Tiempo y Color
        //a partir de la acciones
        public Acciones ConstrutorAcciones()
        {
            Habilidad habilidad = ConstructorHabilidad();
            Tiempo tiempo = ConstructorTiempo();
            Color color = ConstructorColor();
            return new Acciones(habilidad, tiempo, color, _descripcion);
        }
    }
}
