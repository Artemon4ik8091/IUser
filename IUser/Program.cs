using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthoriseXML
{
    public interface IUser
    {
        internal class User
        {
            string _name;
            string _password;
            DateTime _birthDate;
            string Login { get => _name; set => _name = value; }
            string Password { get => _password; set => _password = value; }
            DateTime DateOfBirth { get => _birthDate; set => _birthDate = value; }
            User(string name, string password, DateTime dateOfBirth)
            {
                Login = name;
                Password = password;
                DateOfBirth = dateOfBirth;
            }
        }

    }

}