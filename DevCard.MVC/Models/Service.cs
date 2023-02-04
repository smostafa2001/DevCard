namespace DevCard.MVC.Models
{
    public class Service
    {
        public Service(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
