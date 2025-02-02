﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WVMS.Shared.Dtos.Response
{
    public class ProductSearchResponseDto
    {
        
        public string ProductName { get; set; }

        
        public string Description { get; set; }


        public decimal Price { get; set; }

        
        public int Quantity { get; set; }

        
        public DateTime ExpiryDate { get; set; }
    }
}
