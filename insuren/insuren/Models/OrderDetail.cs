namespace insuren.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public Order Order { get; set; }
        public SubService SubService { get; set; }
    }

    public enum Status
    {
        Success, reject
    }
}
