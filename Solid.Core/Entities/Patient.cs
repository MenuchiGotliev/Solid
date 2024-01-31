namespace Solid.Core.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        public Chemist Chemist { get; set; }
        public List<Medicine> Medicines { get; set; }
    }
}
