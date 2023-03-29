namespace ConsoleApp2_OOP_29_3_2023
{
    class Vector
    {
        public int x { get; } // become readonly (Encapsulation)
        public int y { get; }

        public int Sum
        {
            // convert method to property
            get { return x + y; }
        }

        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }        
    }
}
