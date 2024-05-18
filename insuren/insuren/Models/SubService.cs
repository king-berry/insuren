namespace insuren.Models
{
    public class SubService
    {
        public int Id { get; set; }
        public double price { get; set; }
        public Benefit Benefit { get; set; }
        public Service Service { get; set; }
    }
    public enum Benefit
    {
        normal, normal_extra, normal_premium, normal_postmium

    }
}
