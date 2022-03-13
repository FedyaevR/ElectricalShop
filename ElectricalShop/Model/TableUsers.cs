using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElectricalShop.Model
{
    class TableUsers
    {

        public async Task<bool> AddNewUser(string _firstName, string _lastName, int _age, string _userCategory, string _login, string _password)
        {
            if (_firstName == "" || _lastName == "")
            {
                throw new ArgumentException("Short FirstName or LastName");
            }
            using (DB_Users db = new DB_Users())
            {
                User _user = new User();
                if (await Task.Run(()=> db.User.FirstOrDefault(u => u.Login == _login)) != null)
                {
                    return false;
                }
                if (_login.Length <= 3 || _password.Length <= 3)
                {
                    throw new ArgumentException("Short login or password");
                }
                _user.FirstName = _firstName;
                _user.LastName = _lastName;
                _user.Age = _age;
                _user.UserCategory = _userCategory;
                _user.Login = _login;
                _user.Password = _password;
                await Task.Run(()=>db.User.Add(_user));
                int count = await Task.Run(() => db.SaveChanges());
                if (count > 0) return true;
                return false;
            }
        }
    }
}
