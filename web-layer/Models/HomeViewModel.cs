using Microsoft.AspNetCore.Mvc.Rendering;

namespace web_layer.Models
{
   public class HomeViewModel
   {
      public OrderFilterValuesViewModel FilterValuesViewModel { get; set; }
      public NewOrderViewModel OrderViewModel { get; set; }
   }
}