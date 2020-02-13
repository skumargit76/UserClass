using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserClass
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var user = new User();
                Console.WriteLine("please enter the username, or q to exit");
                var userName = Console.ReadLine();
                if (userName == "q")
                {
                    break;
                }

                user.Add(userName);              
                //Visual Studio 2013 does not support interpolated strings.I am using 2013 so commented below line.
                //Console.WriteLine($"number of addedUser {user.GetUsersCount()}");
                Console.WriteLine("number of addedUser {0}" ,user.GetUsersCount());
            }

        }
    }
    public class User
    {
        static List<string> UserLst = new List<string>();
        internal  void Add(string userName)
        {
            UserLst.Add(userName);
        }
        internal int GetUsersCount()
        {
            return UserLst.Count();
        }
        
    }
}
