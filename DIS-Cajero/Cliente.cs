using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIS_Cajero
{
    internal class Cliente
    {
        public int Tarjeta;
        public int PIN;

        public Cliente(int tarjeta, int pin)
        {
            this.Tarjeta = tarjeta;
            this.PIN = pin;
        }
        
    }
}
