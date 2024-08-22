using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IqbolApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float ActualAmount { get; set; }
        public float Amount { get; set; }
        public int Count { get; set; }
        public string PhotoId { get; set; }

    }
}
