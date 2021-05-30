using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.hash
{
    /// <summary>
    /// Esta clase se encarga de generar un digito verificador en funcion de un conjunto de parametros.
    /// </summary>
    public static class DigitoVerificador
    {


        /// <summary>
        /// Funcion encargada de generar un digito verificador.
        /// </summary>
        /// <param name="values">objetos a tener en cuenta para generar el digito.</param>
        /// <returns>un numero formado en funcion de la sumotaria de bytes de lo objetos enviados como parametros</returns>
        public static int GenerarDigitoVerificador(params object[] values)
        {
            int verificador = 0;
            for (int i = 0; i < values.Length; i++)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(values[i].ToString());
                foreach (byte b in bytes)
                {
                    verificador += b;
                }
            }

            return verificador;
        }
    }
}
