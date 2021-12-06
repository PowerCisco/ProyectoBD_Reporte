using System;


namespace WindowsFormsApp1.BLL
{
    public class ClienteBLL
    {
        private int _iD;
        private string _nombre;
        private string _apellido;
        private string _cedula;
        private string _telefono;
        private string _email;

        public int ID
        {
            get { return _iD; }


            set { _iD = value; }
        }
        public string Nombre {
            get { return _nombre; }


            set { _nombre = value; }
        }
        public string Apellido {
            get { return _apellido; }


            set { _apellido = value; }
        }
        public string Cedula
        {
            get { return _cedula; }


            set { _cedula = value; }
        }
        public string Telefono
        {
            get { return _telefono; }


            set {_telefono = value; }
        }
        public string Email {
            get { return _email; }


            set { _email = value; }

        }

        public ClienteBLL()
        {

        }
        public ClienteBLL(int iD, string nombre, string apellido, string cedula, string telefono, string email)
        {
            _iD = iD;
            _nombre = nombre;
            _apellido = apellido;
            _cedula = cedula;
            _telefono = telefono;
            _email = email;
        }

    }


}
