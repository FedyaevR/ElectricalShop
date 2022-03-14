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

        public async Task<bool> AddNewUserAsync(string _firstName, string _lastName, int _age, string _userCategory, string _login, string _password)
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
                    throw new ArgumentException("Login is already used");
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
        public async Task<string> EnterAsync(string _login, string _password, bool _admin = false)
        {
            
            using (DB_Users db = new DB_Users())
            {
                User _user = new User();
                if (await Task.Run(() => db.User.FirstOrDefault(u => u.Login == _login)) == null)
                {
                    throw new ArgumentException("This login doesn't exist");
                }
                else
                {
                    _user = await Task.Run(() => db.User.FirstOrDefault(u => u.Login == _login && u.Password == _password));
                    if ( _user.UserCategory == "Администратор")
                    {
                        if (_admin == true)
                        {
                            return "Администратор";
                        }
                        else
                        {
                            throw new ArgumentException("Wrong login or password");
                        }
                       
                    }
                    else
                    {
                        return "Пользователь";
                    }
                }
            }
            
        }
    }
}
