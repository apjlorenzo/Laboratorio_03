using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    public class Reserva
    {
        public List<Reserva> listaReservas = new List<Reserva>();
        int id = 2020;
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public List<Plato> Platos { get; set; }

        public Reserva(int id, string fecha, string hora, List<Plato> platos)
        {
            Id = id;
            Fecha = fecha;
            Hora = hora;
            Platos = platos;
        }
    }
}
