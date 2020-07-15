using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FruitCommerce.Domain.Core.Models
{
    [Table("ProductSuppliers")]
    public class ProductSupplier : ModelBase
    {
        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
