using System;

namespace csharphomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User name daxil edin");
            string username = Console.ReadLine();
            //int minlength = 8;
            //while (username.Length >= minlength)
            //{
            //    Console.WriteLine("minumum 8 simvollu  daxil et");
            //}
            Console.WriteLine("Parol daxil et");
            string password = Console.ReadLine();
            userdata usercontrol = new userdata();
            usercontrol.User = username;
            usercontrol.Password = password;
            Console.WriteLine(usercontrol.User);
        }
    }
}
