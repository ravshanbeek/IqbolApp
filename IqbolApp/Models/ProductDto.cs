using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IqbolApp.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public float Amount { get; set; }
    }
}
