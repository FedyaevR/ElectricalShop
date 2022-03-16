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

        public async Task<bool> AddNewUserAsync(string firstName, string lastName, int age, string userCategory, string login, string password)
        {
            if (firstName == "" || lastName == "")
            {
                throw new ArgumentException("Short FirstName or LastName");
            }
            using (DB_Users db = new DB_Users())
            {
                User user = new User();
                if (await Task.Run(()=> db.User.FirstOrDefault(u => u.Login == login)) != null)
                {
                    throw new ArgumentException("Login is already used");
                }
                if (login.Length <= 3 || password.Length <= 3)
                {
                    throw new ArgumentException("Short login or password");
                }
                user.FirstName = firstName;
                user.LastName = lastName;
                user.Age = age;
                user.UserCategory = userCategory;
                user.Login = login;
                user.Password = password;
                await Task.Run(()=>db.User.Add(user));
                int count = await Task.Run(() => db.SaveChanges());
                if (count > 0) return true;
                return false;
            }
        }
        public async Task<string> EnterAsync(string login, string password, bool admin = false)
        {
            
            using (DB_Users db = new DB_Users())
            {
                User user = new User();
                if (await Task.Run(() => db.User.FirstOrDefault(u => u.Login == login)) == null)
                {
                    throw new ArgumentException("This login doesn't exist");
                }
                else
                {
                    user = await Task.Run(() => db.User.FirstOrDefault(u => u.Login == login && u.Password == password));
                    if ( user.UserCategory == "Администратор")
                    {
                        if (admin == true)
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
