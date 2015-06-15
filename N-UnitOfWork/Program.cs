namespace N_UnitOfWork
{
    using N_UnitOfWork.Infrastructure.Doamin;
    using N_UnitOfWork.Model;
    using N_UnitOfWork.Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account(1000);
            System.Console.WriteLine("{0}", a.Balance);
            Account b = new Account(200);
            System.Console.WriteLine("{0}", b.Balance);

            IUnitOfWork nhUnitOfWork = new NHUnitOfWork();

            IAccountRepository accountRepository = new AccountRepository(nhUnitOfWork);

            AccountService service = new AccountService(accountRepository, nhUnitOfWork);

            service.Transfer(a, b, 500);

            Console.Read();
        }
    }
}
