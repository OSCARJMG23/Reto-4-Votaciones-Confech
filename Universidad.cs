using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reto_4_Votaciones_Confech
{
    public class Universidad
    {
        public string? Nombre { get; set; }
        public int Aceptan { get; set; }
        public int Rechazan { get; set; }
        public int Blancos { get; set; }
        public int Nulos { get; set; }

        public Universidad(string nombre, int aceptan, int rechazan, int blancos, int nulos)
        {
            Nombre = nombre;
            Aceptan = aceptan;
            Rechazan = rechazan;
            Blancos = blancos;
            Nulos = nulos;
        }
    }
}