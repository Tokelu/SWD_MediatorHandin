using System.Collections.Generic;

namespace MediatorHandin
{

    /// This is the concrete Mediator

    class CrowsNest : AbstractCrowsNest
    {
        private Dictionary<string, Character> _characters = new Dictionary<string, Character>();
        public override void Register(Character character)
        {
            if (!_characters.ContainsValue(character))
            {
                _characters[character.Name] = character;
            }
            character.CrowsNest = this;
        }

        public override void Send(string from, string to, string message)
        {
            Character character = _characters[to];
            if (character != null)
            {
                character.Receive(from, message);
            }
        }
    }
}