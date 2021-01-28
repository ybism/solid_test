namespace shapes
{
    //SRP, Interface Segregation
    public class Pizza : Food, HotFood
    {
        public Pizza(double a, double b, double c)
        {
            this.ingredientCost = a;
            this.ingredientCalories = b;
            this.tempreatureOfFood = c;
        }

        public double ingredientCost;
        public double ingredientCalories;
        public double tempreatureOfFood;
        public override double calories()
        {
            return ingredientCalories * 2;
        }

        public override double price()
        {
            return ingredientCost * 2;
        }

        public double tempreature()
        {
            return tempreatureOfFood * 2;
        }
    }
}