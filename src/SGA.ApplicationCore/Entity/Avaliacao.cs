using System;
using System.Collections.Generic;
using System.Text;

namespace SGA.ApplicationCore.Entity
{
    public class Avaliacao
    {
        public Avaliacao()
        {

        }
        public int AvaliacaoId { get; set; }
        public DateTime Data { get; set; }
        public Boolean Aprovado { get; set; }
       

    }
}