using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _TechTore_BLL.Wrapping.Exceptions;

namespace _TechTore_BLL.Services._GenericServices
{
    public interface IGenericService<Dto> where Dto : class
    {
        APIResponse<IEnumerable<Dto>> GetAll();
        APIResponse<Dto> GetByID(int id);
        APIResponse<Dto> Add(Dto dto);
        APIResponse<Dto> Update(Dto dto);
        APIResponse<bool> Delete(int id);
        APIResponse<bool> Delete(Dto dto);
    }
}
