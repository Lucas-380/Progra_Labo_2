using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void MetodoInstancia()
        {
            try 
            {
                new MiClase(200);            
            } 
            catch (Exception ex) 
            {
                throw new MiExcepcion("Esta es una MI EXCEPCION", ex);
            }
        }

    }
}
