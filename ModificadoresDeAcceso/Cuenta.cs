using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Cuenta
    {
        public string Propetario { get; set; }
        private string _identificador;
        public float Saldo { get; set; }
        public string Identificador
        {
            get
            {
                return _identificador;
            }
            set
            {
                if (value.Length == 14)
                {
                    _identificador = value;
                }
                else
                {
                    throw new Exception("Valor debe ser entre 10 y 14");
                }

            }
        }



    }
}
