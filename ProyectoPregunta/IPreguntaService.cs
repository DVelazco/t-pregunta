using ProyectoPregunta.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProyectoPregunta
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPreguntaService" en el código y en el archivo de configuración a la vez.

    [ServiceContract]
    public interface IPreguntaService
    {
        [OperationContract]
        [FaultContract(typeof(PreguntaExistente))]
        Pregunta preguntar(int IDPregunta);

        [OperationContract]
        ICollection<Pregunta> ListarPreguntas();
    }




}
