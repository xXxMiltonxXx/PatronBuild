using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Builder.Core
{
    public class Acciones
    {
        //llamamos a las variables
        Habilidad _habilidad;
        Tiempo _tiempo;
        Color _color;
        string _tipo;

        //metodo usado para la interfaz de usuario
        public override string ToString()
        {
            return $"{_tipo}, Habilidad: {_habilidad.Descripcion},Tiempo: {_tiempo.Descripcion}, Color: {_color.Descripcion}";
        }
        //Constructor de acciones
        //recive que es la habilidad, tiempo, color, tipo descriptivo 
        //se usara para ser representada en la interfaz
        public Acciones(Habilidad habilidad, Tiempo tiempo, Color color, string tipo)
        {
            _habilidad = habilidad;
            _tiempo = tiempo;
            _color = color;
            _tipo = tipo;
        }
    }
}

