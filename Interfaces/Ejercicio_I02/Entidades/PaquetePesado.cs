using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PaquetePesado : Paquete, IAfip
    {
        public PaquetePesado(string codigoSeguimiento, decimal cosotEnvio, string destino, string origen, double pesoKg) : base(codigoSeguimiento, cosotEnvio, destino, origen, pesoKg)
        {
        }

        public override bool TienePrioridad
        {
            get { return false; }
        }

        decimal IAfip.Impuestos 
        {
            get
            {
                return costoEnvio * 0.25M;
            } 
        }

        public override decimal AplicarImpuestos()
        {
            return base.AplicarImpuestos() + ((IAfip)this).Impuestos;
        }

    }
}
