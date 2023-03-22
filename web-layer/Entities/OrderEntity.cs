using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_layer.Entity
{
    [Table("Order")]
    public class OrderEntity : Entity
    {
        [Column(TypeName = "varchar(50)")]
        public string Number { get; set; }

        public DateTime Date { get; set; }

        [Column("ProviderId")]
        [ForeignKey(nameof(ProviderEntity))]
        public int ProviderEntityId { get; set; }

        public virtual ProviderEntity ProviderEntity { get; set; }

        public List<OrderItemEntity> OrderItemEntities { get; set; } = new List<OrderItemEntity>();
    }
}