namespace Solid.Core.Entities
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public List<Patient>Patients { get; set; }

    }
}
