using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClothingStore.Models
{
    public class ProductViewModels
    {
    }
    
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Code { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Column(TypeName = "Text")]
        public string Image { get; set; }

        [StringLength(255)]
        public string ShortDescription { get; set; }

        public string Description { get; set; }

        [Required]
        [Column(TypeName = "Decimal")]
        public decimal Cost { get; set; }

        [Required]
        [Column(TypeName = "Decimal")]
        public decimal Price { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [Required]        
        public bool Discontinued { get; set; }

        [Required]        
        public bool IsFeatured { get; set; }

        [Required]        
        public bool IsNew { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]        
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateAt { get; set; }

        public int CategoryId { get; set; }
        public Category Categories { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "Text")]
        public string Image { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]        
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateAt { get; set; }


        public IList<Product> Products { get; set; }
    }
}