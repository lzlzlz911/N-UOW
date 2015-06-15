using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_UnitOfWork.Infrastructure.Doamin
{
    public interface IUnitOfWorkRepository : IDisposable
    {
        //新增
        void PersistCreationOf(IEntity entity);
        //更新
        void PersistUpdateOf(IEntity entity);
        //删除
        void PersistDeletionOf(IEntity entity);
    }
}
