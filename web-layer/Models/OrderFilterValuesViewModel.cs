﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace web_layer.Models
{
   public class OrderFilterValuesViewModel
   {
      [Required]
      public DateTime DateFrom { get; set; }

      [Required]
      public DateTime DateTo { get; set; }
		

		[ValidateNever]
      public List<string> SelectedOrderNumbers { get; set; }

      [ValidateNever]
      public List<int> SelectedProviderIds { get; set; }

      [ValidateNever]
      public List<string> SelectedOrderItemNames { get; set; }

      [ValidateNever]
      public List<string> SelectedOrderItemUnits { get; set; }


      [ValidateNever]
      public List<SelectListItem> OrderNumbers { get; set; }

      [ValidateNever]
      public List<SelectListItem> ProviderNames { get; set; }

      [ValidateNever]
      public List<SelectListItem> OrderItemNames { get; set; }

      [ValidateNever]
      public List<SelectListItem> OrderItemUnits { get; set; }
	
	}
}