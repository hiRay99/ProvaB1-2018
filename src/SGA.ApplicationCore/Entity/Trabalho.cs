using System;
using System.Collections.Generic;
using System.Text;

namespace SGA.ApplicationCore.Entity
{
   public class Trabalho
    {
        public Trabalho()
        {

        }
        public int TrabalhoId { get; set; }
        public DateTime DataSubmissao { get; set; }
        public String Titulo { get; set; }
        public string Descricao { get; set; }
       
    }
}

