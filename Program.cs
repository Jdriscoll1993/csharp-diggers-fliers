using System;
using System.Collections.Generic;
namespace DiggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Animal Instances

            Parakeet parakeet = new Parakeet();
            Ant ant = new Ant();
            BettaFish bettaFish = new BettaFish();
            CopperheadSnake copperSnake = new CopperheadSnake();
            Earthworm earthworm = new Earthworm();
            Finch finch = new Finch();
            Gerbil gerbil = new Gerbil();
            Mouse mouse = new Mouse();
            Terrapin terrapin = new Terrapin();
            TimberRattlesnake timberSnake = new TimberRattlesnake();

            // Container Instances 
            // Creating a List of particular Interface to hold animals of a certain type
            // Adding animals to their rightful container

            Digger diggerContainer = new Digger();
            diggerContainer.diggers = new List<IDigable>()
            {gerbil, earthworm, ant};

            Swimmer swimmerContainer = new Swimmer();
            swimmerContainer.swimmers = new List<ISwimable>()
            {bettaFish, terrapin};

            Flyer flyerContainer = new Flyer();
            flyerContainer.flyers = new List<IFlyable>()
            {parakeet, finch};


            Walker walkerContainer = new Walker();
            walkerContainer.walkers = new List<IWalkable>()
            {timberSnake, copperSnake, mouse};

        }
    }
}


// Digable - Earthworms, Ants, Girbils
// Walkable - Timber Rattlesnake, Mice, Copperhead snake,
// Swimable - Terrapins, Betta Fish, 
// Flyable - Parakeets, Finches,