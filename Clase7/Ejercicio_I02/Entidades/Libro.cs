﻿namespace Entidades
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get
            {
                if(i > -1 && i < this.paginas.Count)
                {
                    return paginas[i];
                }
                return "Pagina invalida";
            }
            set
            {
                if (i > this.paginas.Count)
                {
                    this.paginas.Add(value);
                }else if (i > -1)
                {
                    this.paginas.Insert(i, value);
                }
            }
        }


    }
}