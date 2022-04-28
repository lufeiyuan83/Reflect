using System;

namespace API
{
    public class Account
    {
        public string Username { get; set; } = "lfy_83";
        public void PrintName(string name)
        {
            Console.WriteLine("Hello World! " + name);
        }
    }
}
