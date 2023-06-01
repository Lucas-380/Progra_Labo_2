using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestoAfip;

        public GestionImpuestos()
        {
            this.impuestosAduana = new List<IAduana>();
            this.impuestoAfip = new List<IAfip>();
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal impuestoAduanaTotal = 0;
            foreach  (IAduana paqueteAduana in this.impuestosAduana)
            {
                impuestoAduanaTotal += paqueteAduana.Impuestos;
            }
            return impuestoAduanaTotal;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal impuestoAfipTotal = 0;
            foreach (IAfip paqueteAfip in this.impuestoAfip)
            {
                impuestoAfipTotal += ((IAfip)paqueteAfip).Impuestos;
            }
            return impuestoAfipTotal;
        }


        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete paqueteAduana in paquetes)
            {
                this.RegistrarImpuestos(paqueteAduana);
            }
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            impuestosAduana.Add(paquete);
            if (paquete is IAfip)
            {
                impuestoAfip.Add((IAfip)paquete);
            }
        }


    }
}
