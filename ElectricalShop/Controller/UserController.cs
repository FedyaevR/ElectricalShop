using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElectricalShop.Model;
using ElectricalShop.View;
using System.Threading.Tasks;

namespace ElectricalShop.Controller
{
    class UserController
    {
        TableUsers _tableUsers = new TableUsers();
        /// <summary>
        /// Асинхронный метод добавления нового пользователя.
        /// </summary>
        /// <param name="firstName">имя</param>
        /// <param name="lastName">фамилия</param>
        /// <param name="age">возраст</param>
        /// <param name="userCategory">Категория:пользователь/админ.</param>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <returns>Успешено ли добавление</returns>
        public async Task<bool>  AddUserAsync(string firstName, string lastName, int age, string userCategory, string login, string password)
        {
            if (await _tableUsers.AddNewUserAsync(firstName, lastName, age,userCategory, login, password))
            {
                return true;
            }
            return false;
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

            if (await _tableUsers.EnterAsync(login, password, admin) == "Администратор")
            {
                return "Администратор";
            }
            else
            {
                return "Пользователь";
            }
        }
        public async Task<int> GetUserId(string login, string password)
        {
           return await _tableUsers.GetUserId(login, password);
        }
    }
}
