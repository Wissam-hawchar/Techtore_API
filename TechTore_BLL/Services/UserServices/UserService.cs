using _TechTore_BLL.Services._GenericServices;
using _TechTore_BLL.Wrapping.Exceptions;
using _TechTore_DAL.Repositries.UserRepo;
using AutoMapper;

namespace _TechTore_BLL.Services.UserServices
{
    using Entity = TechTore_DAL.Models.User;
    using Dto = _TechTore_BLL.DTO.UserDTO;
    public class UserService : GenericService<Entity, Dto>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper) : base(userRepository, mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public override APIResponse<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override APIResponse<bool> Delete(Dto dto)
        {
            throw new NotImplementedException();
        }
    }
}
