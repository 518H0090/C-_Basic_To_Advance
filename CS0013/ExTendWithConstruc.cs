
namespace AllUseInOneClass
{
    public class A
    {
        public A(string msg)
        {

        }
    }

    class B : A
    {
        public B(string msg) : base(msg)
        {

        }
    }
}