namespace Farmacia.Models
{
    public class ClienteModel : FarmaciaModel
    {
        public int clienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string FechaCreacion { get; set; }

 
    }


}
