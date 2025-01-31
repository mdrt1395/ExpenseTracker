using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }

        public int Price {  get; set; }

        [Required ]
        public string? Name { get; set; }

    }
}
