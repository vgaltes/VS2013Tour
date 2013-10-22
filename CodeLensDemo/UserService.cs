using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLensDemo
{
    public class UserService
    {
        public string GetUserName(int idUser)
        {
            var userRepository = new UserRepository();
            return userRepository.GetUserName();
        }
    }
}
