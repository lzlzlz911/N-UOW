using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_UnitOfWork.Infrastructure.Doamin
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="unitofWorkRepository"></param>
        void RegisterUpdate(IEntity entity, IUnitOfWorkRepository unitofWorkRepository);
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="unitofWorkRepository"></param>
        void RegisterAdd(IEntity entity, IUnitOfWorkRepository unitofWorkRepository);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="unitofWorkRepository"></param>
        void RegisterRemoved(IEntity entity, IUnitOfWorkRepository unitofWorkRepository);
        /// <summary>
        /// 提交
        /// </summary>
        void Commit();
    }
}
