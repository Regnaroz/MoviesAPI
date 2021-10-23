using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
   public interface IExpensesRepository
    {
        public List<Expenses> GetExpenses();
        public bool InsertExpenses(Expenses Expense);
        public bool UpdateExpenses(Expenses Expense);
        public bool DeleteExpenses(int id);
        public IEnumerable<double> SumOfExpenses();
    }
}
