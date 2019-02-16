using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ProyectoPreguntaRest.Dominio
{
    [DataContract]
    public class Curso
    {
        [DataMember]
        public int IdCurso { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Tema { get; set; }
    }
}