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

        public async Task<bool>  AddUser(string firstName, string lastName, int age, string userCategory, string login, string password)
        {
            if (await _tableUsers.AddNewUserAsync(firstName, lastName, age,userCategory, login, password))
            {
                return true;
            }
            return false;
        }
        public async Task<string> Enter(string login, string password, bool admin = false)
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
    }
}
