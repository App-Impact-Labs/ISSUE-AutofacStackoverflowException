using Facade.Repositories;

namespace Facade.UoW
{
    public interface IUnitOfWork
    {
        public ITicketsRepository Tickets { get; }
        public IOrdersRepository Orders { get; }
        public IUsersRepository Users { get; }
    }
}
