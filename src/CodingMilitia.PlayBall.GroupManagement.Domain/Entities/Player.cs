namespace CodingMilitia.PlayBall.GroupManagement.Domain.Entities
{
    // TODO
    public class Player
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public Group Group { get; set; }

        public User? User { get; set; }
    }
}