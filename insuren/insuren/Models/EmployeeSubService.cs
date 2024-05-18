namespace insuren.Models
{
    public class EmployeeSubService
    {
        public int Id {  get; set; }
        public Employee Employee { get; set; }
        public Order Order { get; set; }
        public DateTime AssignedDate { get; set; }
    }
}
