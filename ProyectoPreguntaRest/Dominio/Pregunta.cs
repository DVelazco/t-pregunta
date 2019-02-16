using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ProyectoPreguntaRest.Dominio
{
    [DataContract]
    public class Pregunta
    {
        [DataMember]
        public int IDPregunta { get; set; }
        [DataMember]
        public int IDCurso { get; set; }
        [DataMember]
        public int IDAlumno { get; set; }
        [DataMember]
        public string Nivel { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string respuesta { get; set; }


    }
}