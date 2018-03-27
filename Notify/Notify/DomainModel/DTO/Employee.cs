using System.Collections.Generic;

namespace DomainModel.DTO
{
    public partial class Employee
    {
        public Employee()
        {
            this.Messages = new HashSet<Message>();
        }
    
        public long EmployeeID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Message> Messages { get; set; }
    }
}
