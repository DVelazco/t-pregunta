using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProyectoPreguntaRest.Dominio;
using ProyectoPreguntaRest.Persistencia;
using ProyectoPreguntaRest.Error;
using System.ServiceModel.Web;
using System.Net;

namespace ProyectoPreguntaRest
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PreguntaLogService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PreguntaLogService.svc o PreguntaLogService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PreguntaLogService : IPreguntaLogService
    {
        private cursoDAO cursoDAO = new cursoDAO();
        private preguntaDAO preguntaDAO = new preguntaDAO();

        public Pregunta InsertaPreguntaLog(int IDPregunta)
        {
            Pregunta pregunta = preguntaDAO.Obtener(IDPregunta);
            if (pregunta == null)
            {
                throw new WebFaultException<PreguntaExistente>(
                    new PreguntaExistente()
                    {
                        CodigoError = 10,
                        MensajeError = "la pregunta con ID  " + IDPregunta + " no existe."
                    }, HttpStatusCode.NoContent);
            }

            return pregunta;
        }

        public Pregunta crear(int IDAlumno, int IDcurso, string Descripcion, string Nivel, string respuesta)
        {
            if (IDAlumno == 0)
            {
                throw new FaultException<PreguntaExistente>(
                    new PreguntaExistente()
                    {
                        CodigoError = 20,
                        MensajeError = "Es necesario que inicie sesión."
                    }, new FaultReason("Error al crear pregunta."));
            }

            Pregunta pregunta = new Pregunta();

            pregunta.IDAlumno = IDAlumno;
            pregunta.IDCurso = IDcurso;
            pregunta.Descripcion = Descripcion;
            pregunta.Nivel = Nivel;
            pregunta.respuesta = respuesta;

            pregunta = preguntaDAO.Crear(pregunta);

            return pregunta;
        }
        public Curso cursado(int IDCurso)
        {
            Curso curso = cursoDAO.Obtener(IDCurso);
            if (curso == null)
            {
                throw new FaultException<PreguntaExistente>(
                 new PreguntaExistente()
                 {
                     CodigoError = 30,
                     MensajeError = "el curso con ID  " + IDCurso + " no existe."
                 }, new FaultReason("Error al obtener curso."));
            }

            return curso;
        }
        

        public Pregunta InsertaPreguntaLog(Pregunta pregunta)
        {
            throw new NotImplementedException();
        }
    }

}
