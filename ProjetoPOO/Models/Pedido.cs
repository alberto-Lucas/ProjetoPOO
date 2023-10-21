using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoPOO.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime DtHora { get; set; }
        public Cliente Cliente { get; set; }
    }
}
