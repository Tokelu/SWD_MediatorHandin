

using System;

namespace MediatorHandin
{
    class Program
    {
        // The main part, where all the interactions take place. 
        static void Main()
        {
            // instantiating the CrowsNest .. this is our Mediator
            CrowsNest crowsNest = new CrowsNest();

            // First we create the characters  
            Character Jon = new GoT_Person("Jon Snow");
            Character Varys = new GoT_Person("Varys");
            Character Tyrion = new GoT_Person("Tyrion Lannister");
            Character Arya = new GoT_Person("Arya Stark");
            Character Jaquen = new GoT_Person("Jaquen H\'gar");
            Character Ramsay = new GoT_Person("Ramsay Bolton");
            Character Reek = new GoT_Person("Reek");
            Character Cersei = new GoT_Person("Cersei Lannister");
            Character Joffrey = new GoT_Person("Joffrey Baratheon");
            Character Daenerys = new GoT_Person("Daenerys Targaryen");
            Character TV_Viewer1 = new NonGoT_Person("TV Viewer 1");
            Character TV_Viewer2 = new NonGoT_Person("TV Viewer 2");

            // Then we register them with the mediator
            crowsNest.Register(Jon);
            crowsNest.Register(Varys);
            crowsNest.Register(Tyrion);
            crowsNest.Register(Arya);
            crowsNest.Register(Jaquen);
            crowsNest.Register(Ramsay);
            crowsNest.Register(Reek);
            crowsNest.Register(Cersei);
            crowsNest.Register(Joffrey);
            crowsNest.Register(Daenerys);
            crowsNest.Register(TV_Viewer1);
            crowsNest.Register(TV_Viewer2);

            // The characters send messages to each other.
            Daenerys.Send("Tyrion Lannister", "Lannister, Targaryen, Baratheon, Stark, Tyrell they’re all just spokes on a wheel. This one’s on top, then that one’s on top, and on and on it spins crushing those on the ground. I’m not going to stop the wheel, I’m going to break the wheel.");
            Jon.Send("Arya Stark", "Stick 'em with the pointy end.");
            Varys.Send("Tyrion Lannister", "Power resides where men believe it resides. It's a trick; a shadow on the wall.");
            Tyrion.Send("Jon Snow", "Never forget what you are. The rest of the world will not. Wear it like armour, and it can never be used to hurt you.");
            Jaquen.Send("Arya Stark", "A girl is finally a no-one.");
            Arya.Send("Jaquen H\'gar", "A girl is Arya Stark of Winterfell. And I\'m going home.");
            Cersei.Send("Jon Snow", "A Lannister always pays his debts.");
            Joffrey.Send("Tyrion Lannister", " Everyone is mine to torment. You\'d do well to remember that you little monster. ");
            Ramsay.Send("Reek", "If you think this has a happy ending, you haven\'t been paying attention.");

            TV_Viewer1.Send("TV Viewer 2", "Oooof ... all those sex scenes, its disg..");
            TV_Viewer2.Send("TV Viewer 1", "I know right!! its AWESOME!");
            
            Console.ReadKey();
        }
    }


    
}