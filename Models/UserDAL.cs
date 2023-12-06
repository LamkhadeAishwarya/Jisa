using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Jisa.Models
{
    public class UserDAL
    {
        List<User> Users;
        public UserDAL()
        {
            Users = new List<User>()
            {
                new User {UserName="Aishwarya",Email="aishwaryalamkhade@gmail.com",Password="123" }
            };
            
           
    
             
        }
       public int Validation(User u)
        {
            int res = 0;
            foreach (var user in Users)
            {
                if (u.UserName == user.UserName)
                {
                    res = 1;
                }
            }
            return res;
        }


    }
}
