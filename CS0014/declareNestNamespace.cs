namespace A
{
    public struct StructInA { };
}
namespace A.B
{
    public struct StructInB { };
}
namespace A.B.C
{
    public struct StructInC { };
}

// Are seam

namespace D
{
    public struct StructInD { };

    namespace E
    {
        public struct StructInE { };

        namespace F
        {
            public struct StructInF { };
        }
    }
}

// đặt tên cho namespace và sử dụng

// using XYZ = System.Text;

// //... các thành phần khác

//     static void Main(string[] args)
// {

//     XYZ.StringBuilder stringBuilder = new XYZ.StringBuilder();
// }