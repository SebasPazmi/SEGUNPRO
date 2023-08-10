using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Farmacia.Models
{
    public abstract class FarmaciaModel
    {
        public string Id { get; set; }
        public bool Estado { get; set; }
        public string FechaCreacion { get; set; }

        public FarmaciaModel()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Id},{Estado},{FechaCreacion}";
        }
    }
}
