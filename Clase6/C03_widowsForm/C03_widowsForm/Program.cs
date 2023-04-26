namespace C03_widowsForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MaquinaExpendedora());

            //Parte 1
            /*
            Dictionary <int, string> maquinaExpendedora = new Dictionary<int, string> ();

            maquinaExpendedora.Add(1, "Papas");
            maquinaExpendedora.Add(2, "Saladix");
            maquinaExpendedora.Add(3, "Alfajor");
            maquinaExpendedora.Add(4, "Galletitas");
            maquinaExpendedora.Add(5, "CocaCola");
            maquinaExpendedora.Add(6, "Pepsi");
            maquinaExpendedora.Add(7, "Agua");
            maquinaExpendedora.Add(8, "Caramelo");
            maquinaExpendedora.Add(9, "Chupetin");
            maquinaExpendedora.Add(10, "Chocolate");

            string entradaUsuario = "";
            int entradaUsuarioEntero = 0;
            
            while(entradaUsuario != "s" && maquinaExpendedora.Count > 0)
            {
                Console.WriteLine("\tMAQUINA EXPENDEDORA");
                foreach (KeyValuePair<int, string> item in maquinaExpendedora)
                {
                    Console.WriteLine($"Posicion: {item.Key} - Producto: {item.Value}");
                }

                Console.WriteLine("Elija el producto que desea llevar o ingrese s para salir: ");
                entradaUsuario = Console.ReadLine();

                if (int.TryParse(entradaUsuario, out entradaUsuarioEntero))
                {
                    Console.WriteLine($"Elijio el producto {maquinaExpendedora[entradaUsuarioEntero]}");
                    maquinaExpendedora.Remove(entradaUsuarioEntero);
                }
                else
                {
                    entradaUsuario = entradaUsuario.ToLower();
                    if (entradaUsuario != "s")
                    {
                        Console.WriteLine("Error - debe ingresar una posicion valida");
                    }
                    else { Console.WriteLine("ADIOS"); }
                }
            }

            

            //Parte 2

            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();

            Stack<Producto> papasFritas = new Stack<Producto>();
            Stack<Producto> bebidas = new Stack<Producto>();
            Stack<Producto> galletitas = new Stack<Producto>();
            Stack<Producto> alfajor = new Stack<Producto>();

            for (int i = 0; i < 3; i++)
            {
                papasFritas.Push(new Producto("Papas Fritas", 350));
                bebidas.Push(new Producto("Agua", 100));
                galletitas.Push(new Producto("Terrabusi", 270));
                alfajor.Push(new Producto("Jorgito", 120));
            }

            maquinaExpendedora.Add(1, papasFritas);
            maquinaExpendedora.Add(2, bebidas);
            maquinaExpendedora.Add(3, galletitas);
            maquinaExpendedora.Add(4, alfajor);

            string entradaUsuario = "";
            int entradaUsuarioEntero = 0;

            while (entradaUsuario != "s" && maquinaExpendedora.Count > 0)
            {
                Console.WriteLine("\tMAQUINA EXPENDEDORA");
                foreach (KeyValuePair<int, Stack<Producto>> item in maquinaExpendedora)
                {
                    Console.WriteLine($"Posicion: {item.Key} - Producto: {item.Value.Peek().Nombre}");
                }

                Console.WriteLine("Elija el producto que desea llevar o ingrese s para salir: ");
                entradaUsuario = Console.ReadLine();

                if (int.TryParse(entradaUsuario, out entradaUsuarioEntero) && maquinaExpendedora.ContainsKey(entradaUsuarioEntero))
                {
                    Producto productoElejido = maquinaExpendedora[entradaUsuarioEntero].Pop();
                    Console.WriteLine($"Elijio el producto {productoElejido.Nombre} - Valor: {productoElejido.Precio} - Codigo: {productoElejido.Codigo}");

                    //verifico si quedan de ese tipo de prod en la maquina
                    if (maquinaExpendedora[entradaUsuarioEntero].Count == 0)
                    {
                        maquinaExpendedora.Remove(entradaUsuarioEntero);
                    }
                }
                else
                {
                    entradaUsuario = entradaUsuario.ToLower();
                    if (entradaUsuario != "s")
                    {
                        Console.WriteLine("Error - debe ingresar una posicion valida");
                    }
                    else { Console.WriteLine("ADIOS"); }
                }
            }

            */

        }
    }
}