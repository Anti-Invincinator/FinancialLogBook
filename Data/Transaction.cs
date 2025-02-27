///
/// Transaction Model
///

using System.ComponentModel.DataAnnotations;

namespace FinancialLogbook.Models
{
    public class Transaction
    {
        [Key]
        public int Id {get; set;} // Transaction ID

        [Required]
        public string Type {get; set;} // Income or Expense

        [Required]
        public string Category {get; set;} // Category of transaction; Food, Salary, Rent, etc.

        [Required]
        public decimal Amount {get; set;}

        [Required]
        public string Description {get; set;}

        [Required]
        public DateTime TransactionDate {get; set;} = DateTime.Now;

    }
}
#pragma warning restore format