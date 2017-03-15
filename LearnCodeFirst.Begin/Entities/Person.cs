namespace LearnCodeFirst.Begin.Entities
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public virtual Student Student { get; set; }
    }

}
