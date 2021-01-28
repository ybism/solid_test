namespace shapes
{
    //Liskov
    public class TotalCalories
    {
        public double caloriesTotal(Pizza[] pizzas)
        {
            double caloriesTotal = 0;

            foreach(Pizza pizza in pizzas)
            {
                caloriesTotal += pizza.calories();
            }

            return caloriesTotal;
        }
    }
}