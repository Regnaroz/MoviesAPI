using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class ExpensesService : IExpensesService
    {
        private readonly IExpensesRepository ExpensesRepository;
        public ExpensesService(IExpensesRepository ExpensesRepository)
        {
            this.ExpensesRepository = ExpensesRepository;
        }
        public bool DeleteExpenses(int id)
        {
            return ExpensesRepository.DeleteExpenses(id);
        }

        public List<Expenses> GetExpenses()
        {
            return ExpensesRepository.GetExpenses();
        }

        public bool InsertExpenses(Expenses Expense)
        {
            return ExpensesRepository.InsertExpenses(Expense);
        }

        public bool UpdateExpenses(Expenses Expense)
        {
            return ExpensesRepository.UpdateExpenses(Expense);
        }
        public IEnumerable<double> SumOfExpenses()
        {
            return ExpensesRepository.SumOfExpenses();

        }
    }
}
