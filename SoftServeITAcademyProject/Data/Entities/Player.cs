namespace SoftServeITAcademyProject.Data.Entities
{
    public class Player
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public PlayerPosition Position { get; set; }
    }
}
