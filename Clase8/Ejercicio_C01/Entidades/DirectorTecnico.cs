﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre) : base(nombre) { }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return (dt1.nombre == dt2.nombre) && (dt1.fechaNacimiento == dt2.fechaNacimiento);
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }

        public new string MostrarDatos()
        {
            return $"Nombre: {base.Nombre}\t" +
                   $"Fecha de nacimiento: {this.fechaNacimiento}\t";
        }


    }
}
