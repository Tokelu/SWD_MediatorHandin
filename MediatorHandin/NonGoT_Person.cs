using System;

namespace MediatorHandin
{

    // Concrete Character class


    // one more Concrete Character class
    class NonGoT_Person : Character
    {
        public NonGoT_Person(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine(" ");
            Console.Write("To a non-GoT_Person: ");
            base.Receive(from, message);
        }
    }

}