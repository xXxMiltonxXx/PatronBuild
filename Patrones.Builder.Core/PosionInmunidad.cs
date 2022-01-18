using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Builder.Core
{
    public class PosionInmunidad : PersonajeConstructor
    {
        public PosionInmunidad()
        {
            _descripcion = "Posion de Inmunidad";
        }
        public override Habilidad ConstructorHabilidad()
        {
            return new Inmunidad();
        }
        public override Tiempo ConstructorTiempo()
        {
            return new Segundos5();
        }
        public override Color ConstructorColor()
        {
            return new Dorado();
        }
    }
}