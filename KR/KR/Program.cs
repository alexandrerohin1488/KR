using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KR
{
    internal class Program
    {
        static void Main(string[] args)
        {
           User user = new User();
            user.SGEmail = "zhidkost@gmail.com";
            Console.WriteLine(user.SGEmail);
            Shop shop = new Shop();
            User user1 = new User();
            User user2 = new User();
            User user3= new User();
            shop.Add(user1);
            shop.Remove(user1);
            shop.Add(user2);
            shop.Add(user3);
            shop.Add(user);
            shop.Notify();
        }
    }
}
