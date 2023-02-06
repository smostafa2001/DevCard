namespace DevCard.MVC.Models
{
    public class Service
    {
        public Service(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public long Id { get; set; }
        public string Name { get; set; }

    }
}
