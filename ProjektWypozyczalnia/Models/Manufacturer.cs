namespace ProjektWypozyczalnia.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        
        public ICollection<Model> Models { get; set; } = new List<Model>();
    }
}
