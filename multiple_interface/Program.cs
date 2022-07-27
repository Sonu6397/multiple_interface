using System;

namespace multiple_interface
{ 
    interface test1
    {
        public void Mymethod();
    }

    interface test2
    {
        public void Show();
      
    }

    class dog : test1, test2
    {
        public void Mymethod()
        {
            Console.WriteLine("this method is test1");
        }

        public void Show()
        {
            Console.WriteLine("this method is test2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dog obj = new dog();
            obj.Mymethod();
            obj.Show();
            Console.ReadLine();
        }
    }
}
