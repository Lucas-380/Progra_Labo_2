using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static int Calcular(char operacion,int numeroUno, int numeroDos)
        {
            int resultado = 0;
            if (operacion == '+')
            {
                resultado = numeroUno + numeroDos;
            }
            else
            {
                if(operacion == '-')
                {
                    resultado = numeroUno - numeroDos;
                }
                else
                {
                    if(operacion == '*')
                    {
                        resultado = numeroUno * numeroDos;
                    }
                    else
                    {
                        if(operacion == '/')
                        {
                            if (Validar(numeroDos))
                            {
                                resultado = numeroUno / numeroDos;
                            }
                            else
                            {
                                Console.WriteLine("NO SE PUEDE DIVIR POR 0");
                            }
                        }
                    }
                }
            }

            return resultado;
        }

        private static bool Validar(int numeroDos)
        {
            if(numeroDos != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }

}
