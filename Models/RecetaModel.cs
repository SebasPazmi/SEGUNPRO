namespace Farmacia.Models
{
    public class RecetaModel : FarmaciaModel
    {

        public string IdCliente { get; set; }
        public string Fecha { get; set; }
        public string IdMedicamento { get; set; }
        public string Cantidad { get; set; }
        public string FechaCreacion { get; set; }

    }

}

