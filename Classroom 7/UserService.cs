using Classroom_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom_7
{
    internal class UserService
    {
        public User[] ShowUser()
        {
            var result = GetAllUser();
            foreach (var user in result)
            {

                Console.WriteLine(item.fullName);

            }
        }
        public user GetUserById() 
        {
            User[] result = GetAllUsers();

            var result = UserService.FirstOrDefault(mbox => m.id == id);

            return user;

            Console.WriteLine(result.fullName);

        }

        var result = GetAllUser();

        public User[] GetAllUser()
        {
            User user1 = new User()
            {
                id = 1,
                fullName = "Aqshin Veliyev",
                age = 25

            };

            User user2 = new User()
            {
                id = 2,
                fullName = "Haci Ehmedov",
                age = 28,

            };

            User user3 = new User()
            {
                id = 3,
                fullName = "Metanet Abbasova",
                age = 21,

            };

            User user4 = new User()
            {
                id = 4,
                fullName = "Meryem Eliyeva",
                age = 23,
            };


            User[] people = { user1, user2, user3, user4 };

        }

    }
}
