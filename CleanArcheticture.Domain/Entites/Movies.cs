namespace CleanArcheticture.Domain.Entites
{
    public class Movie: EntityBase
        {
        public Movie()
        {
        }
        public Movie(string Name, int Cost)
        {
            this.Name = Name;
            this.Cost = Cost;          
        }
        public string Name { get; set; } = string.Empty;
        public int Cost { get; set; }

    }
}
