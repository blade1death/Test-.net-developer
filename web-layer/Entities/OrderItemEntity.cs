using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_layer.Entity
{
    [Table("OrderItem")]
    public class OrderItemEntity : Entity
    {
        [Column("OrderId")]
        public int OrderEntityId { get; set; }

        [ForeignKey(nameof(OrderEntityId))]
        public OrderEntity OrderEntity { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 3)")]
        public decimal Quantity { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Unit { get; set; }
    }
}