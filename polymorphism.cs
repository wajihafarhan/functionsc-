using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace functions
//{
//    //polymorphism Method Overloading
//    public class overloading
//    {
//        public void add()
//        {
//            int a = 2;
//            int b = 3;
//            int c = 4;
//            int result = a + b + c;
//            Console.WriteLine(result);
//        }
//        public void add(int a, int b)
//        {
//            int result = a + b;
//            Console.WriteLine(result);
//        }
//        public void add(float a, int b)
//        {
//            Console.WriteLine(a + b);
//        }
//        public void add(float a, int b, int c)
//        {
//            Console.WriteLine(a + b + c);
//        }
//        public static int add(int x, int y, int z)
//        {
//            return x + y;
//        }
//    }
//    internal class polymorphism
//    {

//        static void Main(string[] args)
//        {
//            overloading ad = new overloading();
//            ad.add();
//            ad.add(4, 9);
//            ad.add(4.7f, 9);
//            ad.add(5.5f, 3, 2);


//        }

//    }
//}
// new work from 25 march

//namespace function
//{
//    public class Parent_class
//    {
//        public virtual void sayhi()
//        {
//            Console.WriteLine("hello from parent class");
//        }
//    }
//    public class Child_class : Parent_class
//    {
//        public override void sayhi()
//        {
//            base.sayhi();
//            Console.WriteLine("hello from child class");
//        }
//    }

//}
namespace function
{
    public class Parent_class
    {
        public virtual void Displayinfo()
        {
            Console.WriteLine("THIS VEHICLE IS FOUR WHEEL DRIVE");
        }
    }
    public class Child_class : Parent_class
    {
        public override void Displayinfo()
        {
            base.Displayinfo();
            Console.WriteLine("This is four wheel drive car of model 2019 and the name of this car is AQUA BLUE ");
        }
    }
    public class Child_class2 : Parent_class
    {
        public override void Displayinfo()
        {
            base.Displayinfo();
            Console.WriteLine("This motorcycle is two wheel drive and have new engine and its colour is blue ");
        }
    }

}