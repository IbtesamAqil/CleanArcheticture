namespace CleanArcheticture.Domain.Entites
{
    public class Movie: EntityBase
        {
        public Movie()
        {
        }
        public Movie(int MovieId, string Name, int Cost)
        {
            this.Id = MovieId;
            this.Name = Name;
            this.Cost = Cost;
        }
        public string Name { get; set; } = string.Empty;
        public int Cost { get; set; }

    }
}
