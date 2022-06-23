﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Yummy.Models
{
    public class Product
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Url { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
