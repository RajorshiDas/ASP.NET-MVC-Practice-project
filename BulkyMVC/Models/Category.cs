using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Categery Name")]
        public string Name { get; set; }= string.Empty;

        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }

   
        
    }
