using web_layer.Service.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_layer.Entity;

namespace web_layer.Service.Filter
{
   internal class OrderDateFilter : IOrderFilter
   {
      public DateTime DateFrom { get; init; }
      public DateTime DateTo { get; init; }

      public OrderDateFilter(DateTime dateFrom, DateTime dateTo)
      {
         if (dateFrom > dateTo)
            throw new ArgumentException($"{nameof(dateFrom)} must be lower in time than {nameof(dateTo)}");

         DateFrom = dateFrom;
         DateTo = dateTo;
      }

      public IQueryable<OrderEntity> Filter(IQueryable<OrderEntity> orders)
      {
         return orders.Where(order => DateFrom <= order.Date && order.Date <= DateTo);
      }
   }
}