using System;
using System.Collections.Generic;
using System.Text;

namespace SGA.ApplicationCore.Entity
{
    public class Endereco
    {
        public Endereco()
        {

        }
        public int EnderecoId { get; set; }
        public String Logradouro { get; set; }
        public String Bairro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
    }
}
