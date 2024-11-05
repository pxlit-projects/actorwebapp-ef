using System.IO.Pipelines;

namespace ActorWebApp.Models
{
    public interface IActorRepository
    {
        IEnumerable<Actor> AllActors { get; }
        Actor? GetActorById(int actorId);
        IEnumerable<Actor> SearchActors(string searchQuery);
    }
}
