using System;
namespace DiggersNFlies
{
    public class Finches : Iflying, Iwalking
    {
        public void Fly ()
        {
            Console.WriteLine("the Finches is flying");
        }
         public void Walk ()
        {
            Console.WriteLine("the Finches is walking");
        }

    }
}