namespace shapes
{
    //Open Closed Principle
    public class MargeritaPizza : Pizza
    {
        public MargeritaPizza(int a, int b, int c, int d) : base(b, c, d)
        {
            this.cheeseCost = a;
        }

        public int cheeseCost;
    }
}