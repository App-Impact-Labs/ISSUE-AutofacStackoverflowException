using Facade.Repositories;
using Facade.UoW;

namespace Facade.Impl.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        public ITicketsRepository Tickets{ get; set; }

        public IOrdersRepository Orders{ get; set; }

        public IUsersRepository Users{ get; set; }
    }
}
