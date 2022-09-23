﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03
{
    public class Cadeteria
    {

        string nombre = "Helljumper Cadeteria";
        uint telefono = 3813300000;
        public List<Cadete> cadetes = new List<Cadete>(); 

        public Cadeteria()
        {

        }

        public void AceptarPedido()
        {
            Pedido nuevo;
        }

        public void AsignarPedido(Pedido asign, Cadete cadete)
        {
            cadete.pedidos.Add(asign);
            // control
            asign.estado = Estado.Asignado; // lo encapsula con un internal??
        }
        
        public static void CambiarEstado(Pedido set)
        {
            // sacar static
            int cnt = 1;
            foreach (Estado estado in (Estado[])Enum.GetValues(typeof(Estado)))
            {
                Console.WriteLine("Si desea cambiar el estado del pedido a {0} presione {1}", estado, cnt);
                cnt++;
            }
            string tmp = Console.ReadLine();
            int entrada = Int32.Parse(tmp);
            // excepciones!!!!!!

            switch (entrada)
            {
                
                default:
                    break;
            }
        }

        public void CambiarCadete(Pedido set)
        {
            int cnt = 1;
            foreach (Cadete cadete in cadetes)
            {
                Console.WriteLine("Si desea asignar el pedido al cadete {0} presione {1}", cadete.name, cnt);
                cnt++;
            }
            string tmp = Console.ReadLine();
            int entrada = Int32.Parse(tmp);
            // excepciones!!!!!!

            // index de cadete
        }

    }
}
