using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreEscuela.Entidades;

namespace CoreEscuela.App
{
    public class Reporteador
    {
        Dictionary<LlaveDiccionario,IEnumerable<ObjetoEscuelaBase>> _diccionario;
        public Reporteador(Dictionary<LlaveDiccionario,IEnumerable<ObjetoEscuelaBase>> dicObjetoEscuela)
        {
            if (dicObjetoEscuela == null)
            {
                throw new ArgumentException(nameof(dicObjetoEscuela));
            }
            _diccionario = dicObjetoEscuela;

        }
        public IEnumerable<Evaluacion> GetListaEvaluaciones()
        {
            if(_diccionario.TryGetValue(LlaveDiccionario.Evaluacion, out IEnumerable<ObjetoEscuelaBase> lista))
           {
            return lista.Cast<Evaluacion>();            
           }
           {
            return new List<Evaluacion>();
           }
        }

        public IEnumerable<string> GetListaAsignaturas()
        {
           return GetListaAsignaturas(out var dummy);            

        }

        public IEnumerable<string> GetListaAsignaturas( out IEnumerable<Evaluacion> listaEvaluaciones)
        {
            listaEvaluaciones= GetListaEvaluaciones();

            return (from Evaluacion ev in listaEvaluaciones
                        select ev.Asignatura.Nombre).Distinct();            

        }

        public Dictionary<string, IEnumerable<Evaluacion>> GetDicEvXAsig() 
        {
            var dicRta = new Dictionary<string, IEnumerable<Evaluacion>>();
            var listAsign = GetListaAsignaturas( out var listaEval);

            foreach (var asig in listAsign)
            {
                var evalasig = from eval in listaEval
                                    where eval.Asignatura.Nombre == asig
                                    select eval;
                dicRta.Add(asig, evalasig);
            }

            return dicRta;

        }
    }
}