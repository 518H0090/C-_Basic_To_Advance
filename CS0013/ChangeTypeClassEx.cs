
namespace AllUseInOneClass
{
    public class Az
    {

    }

    class Bz : Az
    {

    }

    class Cz : Bz
    {

    }

    /*

    C c = new C();
    a = (A)c;       // chuyển kiểu tường minh
    a = c;          // ngầm định
    a = new C();    // ngầm định

    B b = c;        // ngầm định

    c = new A();    // lỗi - không thể chuyển kiểu thuận cây kế thừa -  Lớp cha không chuyển thành con được
    */
}