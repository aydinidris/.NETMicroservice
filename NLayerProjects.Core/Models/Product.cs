using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProjects.Core.Models
{
    class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public bool isDeleted { get; set; }

        public string innerBarcode { get; set; }

        public virtual Category Category { get; set; }

    }
}
