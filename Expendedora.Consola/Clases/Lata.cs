using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Consola.Clases
{
    class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;

        public string Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                this._codigo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public string Sabor
        {
            get
            {
                return this._sabor;
            }
            set
            {
                this._sabor = value;
            }
        }

        public double Precio
        {
            get
            {
                return this._precio;
            }
            set
            {
                this._precio = value;
            }
        }

        public double Volumen
        {
            get
            {
                return this._volumen;
            }
            set
            {
                this._volumen = value;
            }
        }

        public string GetDatosTotales()
        {
            return _nombre + " - " + _precio.ToString() + " $" + _precio + " / $/L" + this.GetPrecioPorLitro().ToString();
        }

        private double GetPrecioPorLitro()
        {
            return this._precio * 1000 / _volumen;
        }

    }
}
