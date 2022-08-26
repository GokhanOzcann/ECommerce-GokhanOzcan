using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
        public Tag Tag { get; set; }
        public int TagId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
