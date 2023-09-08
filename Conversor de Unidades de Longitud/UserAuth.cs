using System;
using System.Collections.Generic;
using System.Linq;


namespace Conversor_de_Unidades_de_Longitud
{
    class UserAuth
    {
        List<UserClass> userList = new List<UserClass>
        {
            new UserClass { Username = "UFG", Password = "1234"},
            new UserClass { Username = "jperez", Password = "123"},
        };

        public UserClass Auth(string username, string password)
        {
            return userList?.FirstOrDefault(user => user.Username == username && user.Password == password);
        }
    }
}
