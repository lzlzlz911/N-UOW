using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_UnitOfWork.Model
{
    public interface IAccountRepository
    {
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="account"></param>
        void Save(Account account);
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="account"></param>
        void Add(Account account);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="account"></param>
        void Remove(Account account);
    }
}
