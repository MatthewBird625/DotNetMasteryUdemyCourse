using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {

        //data annotation that creates a primary key
        [Key]
        public int Id { get; set; }
        //makes following member variable compulsory(required)
        [Required]
        public string Name { get; set; }
  
        public int DisplayOrder { get; set; }
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;  
    }
}
