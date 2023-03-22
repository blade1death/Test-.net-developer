﻿using Microsoft.EntityFrameworkCore;
using web_layer.Entity;
using web_layer.Service.Filter;

namespace web_layer.Service
{
	public class OrderService : IOrderService
	{
		private readonly ApplicationDbContext dbContext;

		public OrderService(ApplicationDbContext dbContext)
		{
			ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));

			this.dbContext = dbContext;
		}

		public Result CreateOrder(OrderEntity order)
		{
			var result = new Result() { Success = true };

			try
			{
				dbContext.Orders.Add(order);
				dbContext.SaveChanges();
			}
			catch (Exception e)
			{
				result.Success = false;
				result.Message = e.Message;
			}

			return result;
		}

		public OrderEntity? GetOrderById(int id)
		{
			return dbContext.Orders.Include(order => order.OrderItemEntities)
								   .Include(order => order.ProviderEntity)
								   .FirstOrDefault(order => order.Id == id);
		}

		public List<OrderEntity> GetOrders()
		{
			var ordersWithIncludings = dbContext.Orders.Include(order => order.ProviderEntity)
													   .Include(order => order.OrderItemEntities);
			return ordersWithIncludings.ToList();
		}

		public List<OrderEntity> GetOrders(OrderFilteringObject filteringObject)
		{
			
			var ordersWithIncludings = dbContext.Orders.Include(order => order.ProviderEntity)
													   .Include(order => order.OrderItemEntities);
			return filteringObject.Apply(ordersWithIncludings).ToList();
		}

		public Result UpdateOrder(OrderEntity order)
		{
			var oldOrder = dbContext.Orders.Include(o => o.OrderItemEntities)
										   .FirstOrDefault(o => o.Id == order.Id);
			if (oldOrder == null)
				return new Result() { Success = false, Message = $"Order with id = {order.Id} doesn't exists" };

			if (oldOrder.OrderItemEntities.Any(item => item.Name == order.Number))
			{
				return new Result()
				{
					Success = false,
					Message = $"Can't update cause there is an order item with name {order.Number}"
				};
			}

			if (dbContext.Orders.Any(o => o.Number == order.Number && o.ProviderEntityId == order.ProviderEntityId))
			{
				return new Result()
				{
					Success = false,
					Message = "Order with such (number, provider) already exists"
				};
			}

			oldOrder.Number = order.Number;
			oldOrder.Date = order.Date;
			oldOrder.ProviderEntityId = order.ProviderEntityId;

			try
			{
				dbContext.Orders.Update(oldOrder);
				dbContext.SaveChanges();

				return new Result() { Success = true };
			}
			catch (Exception e)
			{
				return new Result()
				{
					Success = false,
					Message = e.Message
				};
			}
		}
	}
}
