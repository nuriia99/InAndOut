
using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
	public class Expense
	{
		public int Id { get; set; }
		
		[Required]
		public string Name { get; set;}

		[Range(1,int.MaxValue, ErrorMessage = "Amount must be positive.")]
		public int Amount { get; set; }
	}
}
