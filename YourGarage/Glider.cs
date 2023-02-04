namespace YourGarage
{
    public class Glider : Vehicle, IFlying
    {
        public string Material { get; set; }
        public int MaxAltitude { get; set; }

        public void Fly()
        {
            Console.WriteLine("You run off the edge of the cliff and start flying.");
        }

        public void Land()
        {
            Console.WriteLine("You gently float gradually down and safely land in a field.");
        }

                //public override void Refuel()
        //{
        //    Console.WriteLine("ERROR! GLIDERS DON'T USE FUEL!");
        //}
    }
}
