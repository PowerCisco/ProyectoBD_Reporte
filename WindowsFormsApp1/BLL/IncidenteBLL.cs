using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
    public class IncidenteBLL
    {
        public int ID { get; set; }
        public string Estado { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime FechaCierre { get; set; }
        public string Comentario { get; set; }
        public int IDCliente { get; set; }


        //Constructores


        public IncidenteBLL(int id, string estado, DateTime fechaApertura, DateTime fechaCierre, String comentario, int iDCliente )
        {
            ID = id;
            Estado = estado;
            FechaApertura = fechaApertura;
            FechaCierre = fechaApertura;
            Comentario = comentario;
            IDCliente = iDCliente;

        }
    }
}
