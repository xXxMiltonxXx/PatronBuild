using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Builder.Core
{
    public class PosionVelocidad : PersonajeConstructor
    {

        public PosionVelocidad()
        {
            _descripcion = "Posion de Velocidad";
        }
        public override Habilidad ConstructorHabilidad()
        {
            return new Velocidad();
        }
        public override Tiempo ConstructorTiempo()
        {
            return new Segundos8();
        }
        public override Color ConstructorColor()
        {
            return new Azul();
        }


    }
}
