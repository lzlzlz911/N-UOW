using N_UnitOfWork.Infrastructure.Doamin;
using N_UnitOfWork.Model;
using N_UnitOfWork.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_UnitOfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account(1000);
            System.Console.WriteLine("现在张三,存有{0}", a.Balance);
            Account b = new Account(200);
            System.Console.WriteLine("现在李四,存有{0}", b.Balance);
            System.Console.WriteLine("张三准备转500元给李四，转战开始了......");

            //声明要使用的UnitOfWork
            IUnitOfWork nhUnitOfWork = new NHUnitOfWork();

            //声明要使用的Repository
            IAccountRepository accountRepository = new AccountRepository(nhUnitOfWork);

            AccountService service = new AccountService(accountRepository, nhUnitOfWork);

            service.Transfer(a, b, 500);
        }
    }
}
