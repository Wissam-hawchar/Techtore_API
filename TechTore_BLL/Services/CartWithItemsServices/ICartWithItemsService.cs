using _TechTore_BLL.DTO;
using _TechTore_BLL.Services._GenericServices;
using _TechTore_BLL.Wrapping.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TechTore_BLL.Services.CartWithItemsServices
{
    using Dto = _TechTore_BLL.DTO.CartWithItemsDTO;
    public interface ICartWithItemsService : IGenericService<Dto>
    {
        APIResponse<Dto> AddCartWithItems(Dto dto);
    }
}
