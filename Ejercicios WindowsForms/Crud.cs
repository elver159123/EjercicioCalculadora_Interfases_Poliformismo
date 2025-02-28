using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    internal class Crud
    {
        public List<Pclss> lista = new  List<Pclss>();

        public void agregarObjeto(Pclss p)
        {
            lista.Add(p);
        }
    }
}
