using Entidades.Enumerados;


namespace Entidades.MetodosDeExtension
{
    public static class IngredientesExtension
    {
        public static double CalcularCostoIngredientes(this List<EIngrediente> ingredientes, int costoInicial) 
        {
            double costosIncrementado = costoInicial;

            foreach (EIngrediente ingrediente in ingredientes)
            {
                double incremento = costoInicial * ((int)ingrediente / 100);
                costosIncrementado += incremento;
            }

            return costosIncrementado;
        }

        public static List<EIngrediente> IngredientesAleatorios(this List<EIngrediente> lista, Random rand)
        {
            List<EIngrediente> ingredientes = new List<EIngrediente>()
            {
                EIngrediente.QUESO,
                EIngrediente.PANCETA,
                EIngrediente.ADHERESO,
                EIngrediente.HUEVO,
                EIngrediente.JAMON,
            };

            int random = rand.Next(1, ingredientes.Count + 1);

            return lista.Take(random).ToList();
        }
    }

}
