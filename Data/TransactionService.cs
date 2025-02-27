using FinancialLogbook.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialLogbook.Services
{
    public class TransactionService{
        private readonly List<Transaction> _transactions = new();

        public Task<List<Transaction>> GetTransactionsASync()
        {
            return Task.FromResult(_transactions.OrderByDescending(t => t.TransactionDate).ToList());
        }

        public Task AddTransactionAsync(Transaction transaction)
        {
            transaction.Id = _transactions.Count + 1;
            _transactions.Add(transaction);
            return Task.CompletedTask;
        }

        public Task DeleteTransactionAsync(int id)
        {
            var transaction = _transactions.FirstOrDefault(t => t.Id == id);
            if (transaction != null)
            {
                _transactions.Remove(transaction);
            }
            return Task.CompletedTask;
        }
    }
}