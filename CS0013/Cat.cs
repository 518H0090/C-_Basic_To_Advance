
namespace AllUseInOneClass
{
    public class Cat : Animal
    {
        public string food { set; get; }

        public Cat()
        {
            Legs = 4;
            food = "Fish";
        }

        public void Eat()
        {
            Console.WriteLine(food);
        }
    }
}