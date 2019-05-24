using System;
using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IIncomeExpenseRepository
    {
        void Add(IncomeExpense entity);
        List<IncomeExpense> All();
        IncomeExpense Find(int id);
        List<IncomeExpense> Find(DateTime dt);
        void Remove(int id);
        void Remove(IncomeExpense entity);
        void Update(IncomeExpense entity);
        IList<IncomeExpense> Search(string StrSearch);
        decimal GetLastMoneyIn();
        int GetCurrentId();
        List<PurposeSuggestion> GetAllPurpose();
    }
}
