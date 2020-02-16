using Facade.Repositories;

namespace Facade.Impl.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        public ITicketsRepository Tickets { get; set; }
        public IUsersRepository Users { get; set; }
    }
}
