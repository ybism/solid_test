namespace shapes
{
    //SRP, Liskov
    public abstract class Food
    {
        public abstract double calories();
        public abstract double price();
    }
}