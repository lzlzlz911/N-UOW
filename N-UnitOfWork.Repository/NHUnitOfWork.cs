using N_UnitOfWork.Infrastructure;
using N_UnitOfWork.Infrastructure.Doamin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace N_UnitOfWork.Repository
{
    public class NHUnitOfWork : IUnitOfWork
    {
        private Dictionary<IEntity, IUnitOfWorkRepository> addedEntities;
        private Dictionary<IEntity, IUnitOfWorkRepository> changedEntities;
        private Dictionary<IEntity, IUnitOfWorkRepository> deletedEntities;

        public void RegisterUpdate(IEntity entity, IUnitOfWorkRepository unitofWorkRepository)
        {
            if (!changedEntities.ContainsKey(entity))
            {
                changedEntities.Add(entity, unitofWorkRepository);
            }
        }

        public void RegisterAdd(IEntity entity, IUnitOfWorkRepository unitofWorkRepository)
        {
            throw new NotImplementedException();
        }

        public void RegisterRemoved(IEntity entity, IUnitOfWorkRepository unitofWorkRepository)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                foreach (IEntity entity in addedEntities.Keys)
                {
                    addedEntities[entity].PersistCreationOf(entity);
                }

                scope.Complete();
            }
        }
    }
}
