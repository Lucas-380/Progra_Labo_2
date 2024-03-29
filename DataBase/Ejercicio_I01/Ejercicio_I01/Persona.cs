﻿namespace Ejercicio_I01
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Id { get => id;}
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }


        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido}";
        }

    }
}