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

        public async Task<bool>  AddUser(string _firstName, string _lastName, int _age, string _userCategory, string _login, string _password)
        {
            if (await _tableUsers.AddNewUserAsync(_firstName, _lastName, _age,_userCategory, _login, _password))
            {
                return true;
            }
            return false;
        }
        public async Task<string> Enter(string _login, string _password, bool _admin = false)
        {

            if (await _tableUsers.EnterAsync(_login, _password, _admin) == "Администратор")
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
