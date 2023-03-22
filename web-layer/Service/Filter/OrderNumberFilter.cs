﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_layer.Entity;

namespace web_layer.Service.Filter
{
   internal class OrderNumberFilter : IOrderFilter
   {
      private List<string> orderNumbers = new List<string>();

      public OrderNumberFilter(params string[] numbers)
      {
         if (numbers == null || numbers.Length == 0)
            throw new ArgumentException($"{nameof(numbers)} shouldn't be null or empty");

         orderNumbers.AddRange(numbers);
      }

      public IQueryable<OrderEntity> Filter(IQueryable<OrderEntity> orders)
      {
         return orders.Where(order => orderNumbers.Contains(order.Number));
      }
   }
}