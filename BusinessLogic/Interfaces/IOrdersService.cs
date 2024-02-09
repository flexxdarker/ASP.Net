using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IOrdersService
    {
        IEnumerable<OrderDto> GetAllByUser(string userId);
        void Create(string userId);
    }
}
