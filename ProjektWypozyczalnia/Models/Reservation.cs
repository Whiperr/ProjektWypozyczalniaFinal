namespace ProjektWypozyczalnia.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StatusId { get; set; }
        public Status? Status { get; set; }
        public int CarId { get; set; }
        public Car? Car { get; set; }
        public string? UserId { get; set; }
        
    }
}
