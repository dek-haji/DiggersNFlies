using System;

namespace DiggersNFlies
{
    public class Ants : Idigging
    {
        private string v;

        public Ants()
        {
        }

        public Ants(string v)
        {
            this.v = v;
        }

        public void Dig()
        {
            Console.WriteLine("the Ants is diggin");
        }
    }
}