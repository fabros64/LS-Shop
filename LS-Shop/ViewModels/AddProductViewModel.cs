﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LS_Shop.Models;

namespace LS_Shop.ViewModels
{
    public class AddProductViewModel
    { 
        public Product Product { get; set; }

        public HttpPostedFileBase NewFile { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}