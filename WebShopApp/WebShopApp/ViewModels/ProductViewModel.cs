using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApp.ViewModels
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }       
        public IFormFile Photo { get; set; }
    }
}
