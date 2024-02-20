using System.ComponentModel.DataAnnotations;

namespace DependencyInjectionDemo.ViewModels.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public decimal? Stock { get; set; }
        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }
    }
}
