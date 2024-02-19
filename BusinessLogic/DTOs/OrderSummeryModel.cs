using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
	public class OrderSummaryModel
	{
		public int Number { get; set; }
		public DateTime Date { get; set; }
		public string UserName { get; set; }
		public decimal OrderSumm { get; set; }
		public IEnumerable<ProductDto> Products { get; set; }
	}
}
