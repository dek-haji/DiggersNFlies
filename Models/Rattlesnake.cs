using System;
namespace DiggersNFlies
{
    public class Rattlesnake : Iwalking, Idigging
    {
        public void Walk ()
        {
            Console.WriteLine( $"the Rattlesnake is moving now");
        }
         public void Dig ()
        {
            Console.WriteLine( $"the Rattlesnake is Digging now");
        }
    }
}