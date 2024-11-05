namespace ActorWebApp.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? ShortBio { get; set; }

        public int BirthYear { get; set; }
        public string? ProfilePictureUrl { get; set; }
    }
}