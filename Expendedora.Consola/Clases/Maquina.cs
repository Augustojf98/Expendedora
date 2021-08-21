using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Consola.Clases
{
    class Maquina
    {
        private List<Lata> _latas;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        public bool _encendida;

        public void AgregarLata(Lata lata)
        {
            try
            {
                this._latas.Add(lata);
            }
            catch
            {

            }
        }

        //public Lata ExtraerLata(string codigo, double dinero)
        //{
        //    return this._latas.Equals().;
        //}

        public string GetBalance()
        {
            return "Dinero: " + "$" + this._dinero + ", Latas: " + this._latas.Count();
        }

        public int GetCapacidadRestante()
        {
            return this._capacidad - this._latas.Count();
        }

        public void EncenderMaquina()
        {
            this._encendida = true;
            Console.WriteLine("La máquina fue encendida");
        }

        public bool EstaVacia()
        {
            return this._latas.Count() == 0;
        }
    }
}
