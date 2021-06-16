using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Calendario
    {
        private static Calendario instancia = null;
        private static Dictionary<string, DateTime> eventos = null;
        public static Calendario GetInstancia()
        {
                if (instancia == null)
                    instancia = new Calendario();
                return instancia;
        }
        public Dictionary<string, DateTime> Eventos { get { return eventos; } }
        private Calendario()
        {
            eventos = new Dictionary<string, DateTime>();
        }

        public void AddEvento(string evento, DateTime fecha) => eventos.Add(evento, fecha);
        public void PrintEventos()
        {
            Console.WriteLine("Lista de eventos:");
            foreach (var evento in eventos)
                Console.WriteLine($"-Evento: {evento.Key} Fecha: {evento.Value.ToString("yyyy/MM/dd")}");
        }
    }
}
