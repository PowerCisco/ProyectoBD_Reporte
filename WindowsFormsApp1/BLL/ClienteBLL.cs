using System;


namespace WindowsFormsApp1.BLL
{
    public class ClienteBLL
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public ClienteBLL(int iD, string nombre, string apellido, string cedula, string telefono, string email)
        {
            ID = iD;
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Telefono = telefono;
            Email = email;
        }

    }


}
