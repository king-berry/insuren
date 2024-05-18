namespace insuren.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Rank Rank { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Company Company { get; set; }
        public Acount Acount { get; set; }
    }

    public enum Rank
    {
        None, Employee, Manager
    }
}