using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class Cliente
    {
        public int Tarjeta;
        public int Pin;
        public int Saldo;

        public Cliente() { }
    }

    public static class ClienteCreador
    {
        public static void CrearClientes()
        {
            Cliente cliente1 = new Cliente();
            cliente1.Tarjeta = 1234567890;
            cliente1.Pin = 1234;
            cliente1.Saldo = 100000;

            Cliente cliente2 = new Cliente();
            cliente2.Tarjeta = 987654310;
            cliente2.Pin = 4321;
            cliente2.Saldo = 2000000;

            Cliente cliente3 = new Cliente();
            cliente3.Tarjeta = 567890234;
            cliente3.Pin = 5678;
            cliente3.Saldo = 15000000;
        }
    }  
}


