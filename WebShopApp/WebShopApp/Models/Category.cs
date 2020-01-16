using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}