using System;

namespace MediatorHandin
{

    // The Abstract Character class
    class Character
    {
        private CrowsNest _crowsNest;
        private string _name;

        public Character(string name)
        {
            this._name = name;
        }

        // Gets character name
        public string Name
        {
            get { return _name; }
        }

        // Gets crowsNest
        public CrowsNest CrowsNest
        {
            set { _crowsNest = value; }
            get { return _crowsNest; }
        }
        

        // Sends message to given character
        public void Send(string to, string message)
        {
            _crowsNest.Send(_name, to, message);
        }

        // Receives message from given character
        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
    }
}