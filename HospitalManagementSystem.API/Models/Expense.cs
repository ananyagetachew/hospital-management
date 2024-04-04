using HospitalManagementSystem.API.Models.Base;

namespace HospitalManagementSystem.API.Models
{
    public class Expense : BaseModel
    {
        public ExpenseCatagory ExpenseCatagory { get; set; }

        public int ExpenseCatagoryId { get; set; }
        public float Amount { get; set; }
    }
}
