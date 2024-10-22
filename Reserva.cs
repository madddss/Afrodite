using System.Data;

namespace afrodite.Models
{   public class Reserva
    {
        private int IdReserva { get; set; }
        private int IdCliente { get; set; }
        private int IdProfissional { get; set; }
        private int IdServico { get; set; }
        public StatusReserva Status { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }

        public Reserva(int idReserva, int idCliente, int idProfissional,
            int idServico, StatusReserva status, DateTime dataHoraInicio, DateTime dataHoraFim)
        {
            IdReserva = idReserva;
            IdCliente = idCliente;
            IdProfissional = idProfissional;
            IdServico = idServico;
            Status = StatusReserva.Pendente;
            DataHoraInicio = dataHoraInicio;
            DataHoraFim = dataHoraFim;
        }

        public enum StatusReserva
        {
            Pendente = 1,
            Confirmada = 2,
            Cancelada = 3,
            Concluida = 4
        }

        public void RealizarReserva()
        {

        }
        public void CancelarReserva()
        {

        }
    }
}

