using System;

namespace MediatorHandin
{
    class GoT_Person : Character
    {
        public GoT_Person(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine(" ");
            Console.Write("To a GoT_Person: ");
            base.Receive(from, message);
        }
    }
}