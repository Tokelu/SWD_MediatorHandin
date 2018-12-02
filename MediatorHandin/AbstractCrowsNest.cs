namespace MediatorHandin
{

    // The Mediator abstract class
    abstract class AbstractCrowsNest
    {
        public abstract void Register(Character character);
        public abstract void Send(string from, string to, string message);
    }
}