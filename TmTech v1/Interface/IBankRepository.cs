using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IBankBaseRepository : IBaseRepository<Bank>
    {

        bool hasBranch(Bank bank);
    }

    public interface IBrankBankBaseRepository : IBaseRepository<BrankBank>
    {

        List<BrankBank> GetAllBrankByBankID(string ID);


        List<BrankBank> Search(string searchStr);

    }



    public interface IBankCompanyBaseRepository : IBaseRepository<BankCompany>
    {


    }
} 