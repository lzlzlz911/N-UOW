namespace N_UnitOfWork.Model
{
    using N_UnitOfWork.Infrastructure;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Account : IEntity
    {
        public Account(decimal balance)
        {
            Balance = balance;
        }
        /// <summary>
        /// 账户余额
        /// </summary>
        public decimal Balance { get; set; }
    }
}
