using System;
using System.Collections.Generic;
using System.Text;

namespace SGA.ApplicationCore.Entity
{
    public class Participante
    {
        public Participante()
        {

        }
        public int ParticipanteId { get; set; }

        public String Nome { get; set; }

        public String Email{ get; set; }
    }
}
