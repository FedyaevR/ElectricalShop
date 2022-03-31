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
        /// <summary>
        /// Асинхронный метод добавления нового пользователя.
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="userCategory">Категория:пользователь/админ.</param>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <returns>Успешено ли добавление</returns>
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
        /// <summary>
        /// Асинхронный метод входа в приложение.
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <param name="admin">Статус пользователя - админ?</param>
        /// <returns>Удалось ли войти в приложиние.</returns>
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
                    if (user != null)
                    {
                        if (user.UserCategory == "Администратор")
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
                    else
                    {
                        throw new ArgumentException("Wrong login or password");
                    }
                   
                }
            }
            
        }
        public async Task<int> GetUserId(string login, string password)
        {
            using (DB_Users db = new DB_Users())
            {
                var id = await Task.Run(()=> db.User.FirstOrDefault(i => i.Login == login && i.Password == password).Id);
                return id;            
            }
        }
    }
}
