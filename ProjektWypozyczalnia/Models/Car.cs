namespace ProjektWypozyczalnia.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public int ModelId { get; set; }
        public Model? Model { get; set; }
        public int TypeId { get; set; }
        public CarType? Type { get; set; }
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
