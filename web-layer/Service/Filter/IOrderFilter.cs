
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_layer.Entity;

namespace web_layer.Service.Filter
{
   public interface IOrderFilter
   {
      IQueryable<OrderEntity> Filter(IQueryable<OrderEntity> orders);
      
   }
}