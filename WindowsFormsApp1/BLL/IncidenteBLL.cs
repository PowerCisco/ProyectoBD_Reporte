using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
    public class IncidenteBLL
    {
        private int _iD;
        private string _estado;
        private DateTime _fecha;
        private string _comentario;
        private int _iDCliente;

        public int ID {
            get { return _iD; }


            set { _iD = value; }
        }
        public string Estado {
            get { return _estado; }
                
            
            set { _estado = value; }
        
        }
        public DateTime Fecha {
            get { return _fecha; }


            set { _fecha = value; }
        }
        public string Comentario {
            get { return _comentario; }


            set { _comentario = value; }
        }
        public int IDCliente
        {
            get { return _iDCliente; }


            set { _iDCliente = value; }
        }


        //Constructores
        public IncidenteBLL()
        {

        }

        public IncidenteBLL( int iD, string estado, DateTime fecha, string comentario, int iDCliente)
        {
            _iD = iD;
            _estado = estado;
            _fecha = fecha;
            _comentario = comentario;
            _iDCliente = iDCliente;

        }
    }
}
