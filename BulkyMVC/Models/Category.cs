﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Name cannot be longer than 30 characters")]
        [DisplayName("Categery Name")]
        public string Name { get; set; }= string.Empty;

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100")]
        public int DisplayOrder { get; set; }
    }

   
        
    }
