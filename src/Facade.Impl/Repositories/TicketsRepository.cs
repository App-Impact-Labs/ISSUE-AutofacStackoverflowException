using Facade.Repositories;

namespace Facade.Impl.Repositories
{
    public class TicketsRepository : ITicketsRepository
    {
        public IUsersRepository Users { get; set; }
        public IOrdersRepository Orders { get; set; }
    }
}
