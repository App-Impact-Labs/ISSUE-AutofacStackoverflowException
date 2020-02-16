using Facade.Repositories;

namespace Facade.Impl.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public ITicketsRepository Tickets { get; set; }
        public IOrdersRepository Orders { get; set; }
    }
}
