using ProyectoPreguntaRest.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProyectoPreguntaRest
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPreguntaLogService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPreguntaLogService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "PreguntaLogService", ResponseFormat = WebMessageFormat.Json)]
        Pregunta InsertaPreguntaLog(Pregunta pregunta);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "PreguntaLogService", ResponseFormat = WebMessageFormat.Json)]
        Pregunta crear(int IDAlumno, int IDcurso, string Descripcion, string Nivel, string respuesta);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "PreguntaLogService", ResponseFormat = WebMessageFormat.Json)]
        Curso cursado(int IDCurso);


    }
}
