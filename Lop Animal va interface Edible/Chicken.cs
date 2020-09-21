namespace Lop_Animal_va_interface_Edible
{
    public class Chicken:Animal, Edible
    {
       public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }
        public string HowtoEat()
        {
            return "could be fried";
        }
    }
}