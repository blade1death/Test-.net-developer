
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_layer.Entity;

namespace web_layer.Service.Filter
{
	internal class OrderItemNameFilter : IOrderFilter
	{
		private readonly string[] orderItemNames;

		public OrderItemNameFilter(IEnumerable<string> orderItemNames)
		{
         ArgumentNullException.ThrowIfNull(orderItemNames, nameof(orderItemNames));

			this.orderItemNames = orderItemNames.ToArray();
      }

		public IQueryable<OrderEntity> Filter(IQueryable<OrderEntity> orders)
		{
			return orders.Where(order => order.OrderItemEntities.Any(orderItem => orderItemNames.Contains(orderItem.Name)));
		}
	}
}