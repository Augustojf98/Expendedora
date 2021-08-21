using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Consola.Clases
{
    static class Exceptions
    {
        private static string _capacidadInexistenteException;

        public static string CapacidadInexistente
        {
            get
            {
                return _capacidadInexistenteException = "La máquina no tiene más capacidad.";
            }
        }

        private static string _dineroInsuficienteException;

        public static string DineroInsuficiente
        {
            get
            {
                return _dineroInsuficienteException = "No se ingresó suficiente dinero.";
            }
        }

        private static string _sinStockException;

        public static string SinStock
        {
            get
            {
                return _sinStockException = "La máquina no tiene más stock.";
            }
        }

        private static string _codigoInvalidoException;

        public static string CodigoInvalido
        {
            get
            {
                return _codigoInvalidoException = "El código ingresado es inválido.";
            }
        }
    }
}
