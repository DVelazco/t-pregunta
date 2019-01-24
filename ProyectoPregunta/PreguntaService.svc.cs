using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProyectoPregunta.Persistencia;
using ProyectoPregunta.Dominio;

namespace ProyectoPregunta
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PreguntaService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PreguntaService.svc o PreguntaService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PreguntaService : IPreguntaService
    {
        private cursoDAO cursoDAO = new cursoDAO();
        private preguntaDAO preguntaDAO = new preguntaDAO();

        public string IDcurso { get; private set; }

        public Pregunta preguntar(int IDPregunta)
        {
            Pregunta pregunta = preguntaDAO.Obtener(IDPregunta);
            if (pregunta == null)
            {
                throw new FaultException<PreguntaExistente>(
                    new PreguntaExistente()
                    {
                        CodigoError = 10,
                        MensajeError = "la pregunta con ID pregunta " + IDPregunta + " no existe."
                    }, new FaultReason("Error al obtener pregunta."));
            }

            return pregunta;
        }

        public ICollection<Pregunta> ListarPreguntas()
        {
            throw new NotImplementedException();
        }

        public Pregunta preguntar(int IDPregunta, List<Pregunta> PreguntaExistente)
        {
            throw new NotImplementedException();
        }
    }

}