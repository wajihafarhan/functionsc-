namespace function
{
    internal class Program
    {
        //void does not value return
        void msg()
        {
            Console.WriteLine("simple msg");
        }
        //static method 
        public static void msg2()
        {
            Console.WriteLine("Static method");
        }
        //parametrized method

        public static string fullname(string name1, string name2)
        {
            return $"your fullname is {name1} {name2}";
        }

        public static string Person_Details(string fullname, string lastname, int age)
        {
            return $"your {fullname} and {lastname} your age is{age}  ";
        }
        // class for this. keyword understandings
        class person1
        {
            public int Id;
            public string FirstName;
            public string LastName;
            public string @class;
            public int age;

            public void Detail1(int id, string Fname, string lname, string classs, int Age)
            {
                this.Id = id;
                this.FirstName = Fname;
                this.LastName = lname;
                this.@class = classs;
                this.age = Age;

                Console.WriteLine($"Student Detail = id = {id} \n Firstname = {Fname} \n LastName = {lname} \n class = {classs} \n age = {Age}");
            }
        }
        static void Main(string[] args)
        {
            person1 std = new person1();
            std.Detail1(1, "wajiha", "nadeem", "matric", 27);
            Console.WriteLine(std);

            //    Console.WriteLine("Hello, World!");
            //    Program obj1 = new Program();
            //    obj1.msg();
            //    Program.msg2();
            //    //Program.msg2();
            //    //Program.msg2();
            //    //Console.WriteLine(Program.fullname("sawera","ansari"));
            //    var result = Program.Person_Details("wajiha", "nadeem", 27);
            //    Console.WriteLine(result);
            //}
  Child_class child = new();
  Child_class2 child2 = new();
  child.Displayinfo();
  child2.Displayinfo();
        }
    }
}
