using BookingBoss.Domain;
using BookingBoss.Infrastructure;

namespace BookingBoss.Service
{
    public class UserService : EntityService<UserEntity>, IUserService
    {
        public UserService(IContext context) : base(context)
        {
        }
    }
}
