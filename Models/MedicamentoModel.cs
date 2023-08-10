namespace Farmacia.Models
{
    public class MedicamentoModel : FarmaciaModel
    {
        public int medicamentoId { get; set; }
        public string Nombre { get; set;}
        public string Descripcion { get; set;}
        public int Stock { get; set;}
        public string FechaCreacion { get; set; }

    }
}
