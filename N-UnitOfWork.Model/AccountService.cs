
namespace N_UnitOfWork.Model
{
    using N_UnitOfWork.Infrastructure.Doamin;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AccountService
    {
        private IAccountRepository _IAccountRepository;
        private IUnitOfWork _IUnitOfWork;

        public AccountService(IAccountRepository accountRepository,
                              IUnitOfWork unitOfWork)
        {
            _IAccountRepository = accountRepository;
            _IUnitOfWork = unitOfWork;
        }

        /// <summary>
        /// 转账
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="amount"></param>
        public void Transfer(Account from, Account to, decimal amount)
        {
            if (from.Balance >= amount)
            {
                from.Balance -= amount;
                to.Balance += amount;

                _IAccountRepository.Save(from);
                _IAccountRepository.Save(to);

                _IUnitOfWork.Commit();
            }
        }
    }
}
