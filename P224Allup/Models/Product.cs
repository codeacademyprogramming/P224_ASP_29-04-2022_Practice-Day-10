﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace P224Allup.Models
{
    public class Product : BaseEntity
    {
        [StringLength(255),Required]
        public string Title { get; set; }
        [Column(TypeName ="money")]
        public double DiscountPrice { get; set; }
        [Column(TypeName = "money")]
        public double Price { get; set; }
        [Column(TypeName = "money")]
        public double ExTax { get; set; }
        [StringLength(8)]
        public string Code { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        public int Count { get; set; }
        public string MainImage { get; set; }
        public string HoverImage { get; set; }
        public bool Availability { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsBestseller { get; set; }
        public bool IsFeatured { get; set; }

        [NotMapped]
        public List<int> TagIds { get; set; } = new List<int>();
        [NotMapped]
        public IFormFile[] ProductImagesFile { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }
        [NotMapped]
        public IFormFile HoverImageFile { get; set; }

        public Nullable<int> BrandId { get; set; }
        public Brand Brand { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Category Category { get; set; }
        //public List<ProductTag> ProductTags { get; set; }
        public IEnumerable<ProductTag> ProductTags { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public IEnumerable<Basket> Baskets { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
