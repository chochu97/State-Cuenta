using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Switch
    {
        Estado estado;

        public Switch()
        {
            estado = new Encendido();
        }

        public void DefinirEstado(Estado state)
        {
            estado = state;
        }

        public void Presionar()
        {
            estado.ControlarEstado(this);
            Console.WriteLine(estado.Describir());
        }
    }
}
