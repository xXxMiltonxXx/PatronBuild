using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Builder.Core
{
    public class PosionFuerza : PersonajeConstructor
    {
        public PosionFuerza()
        {
            _descripcion = "Posion fuerza";
        }
        public override Habilidad ConstructorHabilidad()
        {
            return new Fuerza();
        }
        public override Tiempo ConstructorTiempo()
        {
            return new Segundos3();
        }
        public override Color ConstructorColor()
        {
            return new Verde();
        }
    }
}
