using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }
        public int CategoryId { get; set; }
        public string? MaterialName { get; set; }
        public string Unit { get; set; }=string.Empty;
        public double Qty { get; set; }
        public double NetQty { get; set; }
        public string? Discription { get; set; }
        public string Brand { get; set; }=string.Empty;
        public double GST { get; set; }
        public string? GST_Type { get; set; }

    }
}
