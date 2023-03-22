﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_layer.Entity;

namespace web_layer.Service.Filter
{
	internal class OrderProviderIdFilter : IOrderFilter
	{
		private readonly List<int> providerIds = new List<int>();

		public OrderProviderIdFilter(params int[] ids)
		{
			if (ids == null || ids.Length == 0)
				throw new ArgumentException($"{nameof(ids)} must be not null and not empty");

			providerIds.AddRange(ids);
		}

		public IQueryable<OrderEntity> Filter(IQueryable<OrderEntity> orders)
		{
			return orders.Where(order => providerIds.Contains(order.ProviderEntityId));
		}
	}
}