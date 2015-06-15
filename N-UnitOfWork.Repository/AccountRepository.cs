namespace N_UnitOfWork.Repository
{
    using N_UnitOfWork.Infrastructure.Doamin;
    using N_UnitOfWork.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AccountRepository : IAccountRepository, IUnitOfWorkRepository
    {
        private IUnitOfWork _IUnitOfWork;

        public AccountRepository(IUnitOfWork _IUnitOfWork)
        {
            this._IUnitOfWork = _IUnitOfWork;
        }

        public void Save(Account account)
        {
            _IUnitOfWork.RegisterUpdate(account, this);
        }

        public void Add(Account account)
        {
            throw new NotImplementedException();
        }

        public void Remove(Account account)
        {
            throw new NotImplementedException();
        }

        public void PersistCreationOf(Infrastructure.IEntity entity)
        {
            
        }

        public void PersistUpdateOf(Infrastructure.IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void PersistDeletionOf(Infrastructure.IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}