using System;
using System.Collections.Generic;

namespace DiggersNFlies
{
    class Program
    {
        static void Main(string[] args)
        {

            Mice Chedar = new Mice();
            Mice squaker = new Mice();
            Rattlesnake timber = new Rattlesnake();
            Terrapins smallTerrabin = new Terrapins();
            Parakeets smallParakeet = new Parakeets();
            Finches noNameFinch = new Finches();
            BettaFish fish = new BettaFish();
            Gerbils Ger = new Gerbils();
            Earthworms worm = new Earthworms();
            CopperheadSnake snake = new CopperheadSnake();
            Ants anita = new Ants();


            List<Iwalking> WalkingAnimals = new List<Iwalking>()
            {Chedar,timber, Ger, worm, smallTerrabin, squaker};
            Chedar.Walk();

            List<Iswimming> SwimmingAnimals = new List<Iswimming>()
            {fish};

            List<Iflying> FlyingAnimals = new List<Iflying>()
            {smallParakeet, noNameFinch};


            List<Idigging> DiggingAnimals = new List<Idigging>()
            {worm, anita};

        }
    }
}
