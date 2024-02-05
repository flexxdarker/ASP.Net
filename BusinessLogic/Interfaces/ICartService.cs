using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
	public interface ICartService
	{
		IEnumerable<ProductDto> GetProducts();
		void Add(int id);
		void Delete(int id);
		int GetCount();
	}
}
