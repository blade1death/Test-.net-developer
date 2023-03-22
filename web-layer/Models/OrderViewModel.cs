using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace web_layer.Models
{
   public class OrderViewModel
   {
      public int Id { get; set; }

      public string Number { get; set; }

      public DateTime Date { get; set; }

      public string ProviderName { get; set; }
   }
}