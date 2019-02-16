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

        public Pregunta preguntar(int IDPregunta)
        {
            try
            {
                Pregunta pregunta = preguntaDAO.Obtener(IDPregunta);
                if (pregunta == null)
                {
                    throw new FaultException(new FaultReason("No existe una pregunta con ese id especifico"), new FaultCode("10"));
                }

                return pregunta;
            }
            catch (Exception ex)
            {
                throw new FaultException(new FaultReason("Error al obtener pregunta: " + ex.Message.ToString()), new FaultCode("0"));
            }
        }

        public Pregunta crear(string IDAlumno, int IDcurso, string Descripcion, string Nivel, string respuesta)
        {
            try
            {
                if (IDcurso == 0)
                {
                    throw new FaultException(new FaultReason("El curso no existe"), new FaultCode("20"));
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
            catch (Exception ex)
            {
                throw new FaultException(new FaultReason("Error al crear pregunta: " + ex.Message.ToString()), new FaultCode("0"));
            }
        }

        public Curso ObtenerCurso(int IDCurso)
        {
            try
            {
                Curso curso = cursoDAO.Obtener(IDCurso);
                if (curso == null)
                {
                    throw new FaultException(new FaultReason("No existe un curso con ese parametro"), new FaultCode("30"));
                }

                return curso;
            }
            catch (Exception ex)
            {
                throw new FaultException(new FaultReason("Error al obtener curso: " + ex.Message.ToString()), new FaultCode("00"));
            }
        }

        public ICollection<Curso> ListarCurso()
        {
          return cursoDAO.ListarTodos();
        }

        public ICollection<Pregunta> ListarPregunta()
        {
            return preguntaDAO.ListarTodos();
        }
    }

}