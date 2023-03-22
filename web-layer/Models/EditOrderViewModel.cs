using System.ComponentModel.DataAnnotations;

namespace web_layer.Models
{
	public class EditOrderViewModel : NewOrderViewModel
	{
		public int Id { get; set; }
	}
}
