﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IAfip
    {
        public decimal Impuestos{ get; }

        public decimal AplicarImpuestos();

    }
}
