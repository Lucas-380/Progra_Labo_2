using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PaqueteFragil : Paquete
    {
        public PaqueteFragil(string codigoSeguimiento, decimal cosotEnvio, string destino, string origen, double pesoKg) : base(codigoSeguimiento, cosotEnvio, destino, origen, pesoKg)
        {
        }

        public override bool TienePrioridad
        { 
            get { return true; }
        }


    }
}
