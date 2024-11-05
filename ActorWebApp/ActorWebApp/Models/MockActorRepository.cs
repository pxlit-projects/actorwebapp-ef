
namespace ActorWebApp.Models
{
    public class MockActorRepository : IActorRepository
    {
        public IEnumerable<Actor> AllActors
        {
            get
            {
                return new List<Actor>
                    {
                        new Actor
                        {
                            LastName = "Pitt",
                            FirstName = "Brad",
                            BirthYear = 1963,
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Brad_Pitt_2019_by_Glenn_Francis.jpg/640px-Brad_Pitt_2019_by_Glenn_Francis.jpg"
                        },
                        new Actor
                        {
                            LastName = "Jolie",
                            FirstName = "Angelina",
                            BirthYear = 1975,
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4a/Under_Secretary_Zeya_Meets_With_UNHCR_Special_Envoy_Jolie_%2851942861677%29_%28cropped%29.jpg"
                        },
                        new Actor
                        {
                            LastName = "DiCaprio",
                            FirstName = "Leonardo",
                            BirthYear = 1974,
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/4/46/Leonardo_Dicaprio_Cannes_2019.jpg"
                        }
                        // Add more actors as needed
                    };
            }
        }

        public Actor? GetActorById(int actorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actor> SearchActors(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
