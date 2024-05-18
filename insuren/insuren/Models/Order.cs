namespace insuren.Models
{
    public class Order
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public Company Company { get; set; }

    }
}
