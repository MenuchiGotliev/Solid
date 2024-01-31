namespace Solid.Core.Entities
{
    public class Chemist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        public List<Patient>Patients { get; set; }
    }
}
