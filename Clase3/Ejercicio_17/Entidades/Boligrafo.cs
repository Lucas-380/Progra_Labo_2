namespace Entidades
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor getColor()
        {
            return this.color;
        }
        public short getTinta()
        {
            return this.tinta;
        }

        private void setTinta(short tinta)
        {
            this.tinta = (short)(this.tinta + tinta);
            if(this.tinta >= Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = Boligrafo.cantidadTintaMaxima;
            }else if(this.tinta <= 0)
            {
                this.tinta = 0;
            }
        }

        public void Recargar()
        {
            setTinta(Boligrafo.cantidadTintaMaxima);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            string aux = "";
            if(this.getTinta() == 0)
            {
                dibujo = "No se puede pintar";
                return false;
            }
            while (gasto > 0 && this.getTinta() > 0)
            {
                aux += "*";
                gasto--;
                this.setTinta(-1);
            }
            dibujo = aux;
            return true;
        }


    }
}