﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LS_Shop.Models
{
    public class Product
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)] //attributes not to assign Ids by the server
        public int ProductId { get; set; }
        public int CategoryId { get; set; }  //foreign key
        [Required(ErrorMessage = "Wprowadź nazwę produktu")]
        [StringLength(100)]
        public string Name { get; set; }
        public DateTime DateOfAddition { get; set; }
        [StringLength(100)]
        public string NameOfImage { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }

        public virtual Category Category { get; set; }
        public virtual List<OrderPosition> OrderPosition { get; set; }
    }
}