using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace ProyectoPreguntaRest.Error
{
    [DataContract]
    public class PreguntaExistente
    {
        [DataMember]
        public int CodigoError { get; set; }
        [DataMember]
        public string MensajeError { get; set; }

    }
}