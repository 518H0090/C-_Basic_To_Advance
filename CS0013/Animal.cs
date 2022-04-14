
namespace AllUseInOneClass
{
    public class Animal
    {
        protected int Legs { set; get; }
        public float Weight { set; get; }

        public void ShowLegs()
        {
            Console.WriteLine($"Legs : {Legs}");
        }
    }
}