using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public struct POINT
{
    public int x;
    public int y;
}

[StructLayout(LayoutKind.Explicit)]
public struct RECT
{
    [FieldOffset(0)] public int left;
    [FieldOffset(4)] public int top;
    [FieldOffset(8)] public int right;
    [FieldOffset(12)] public int bottom;
}

public class StructApplication
{
    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern bool PtInReat(ref RECT r, POINT p);

    public static void Main()
    {
        RECT myRect = new RECT();
        myRect.left = 1;
        myRect.right = 100;
        myRect.top = 1;
        myRect.bottom = 100;

        POINT myPOINT = new POINT();
        myPOINT.x = 51;
        myPOINT.y = 51;

        bool b = StructApplication.PtInReat(ref myRect, myPOINT);
        if (b == true)
            Console.WriteLine("사각형 내에 좌표가 존재합니다.");
        else
            Console.WriteLine("사각형 내에 좌표가 존재하지 안습니다.");
    }
}

//namespace struct2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}
