    using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace OTSC.LoginPage.LoginView
{
    public interface ILogin
    {
        public string Login { get; set; } //строка логина
        public string Password { get; set; }// строка пароля
        public char PasswordChar { get; set; }// символы скрытия пароля
        public bool isCheckedPass { get; set; }// проверка, скрыт или закрыт пароль
        public event EventHandler btnLogin; //кнопка нажатия войти
        public event EventHandler btnRegister;//кнопка нажатия регистрации
        public event EventHandler btnClear;//кнопка очисти полей
        public event EventHandler btnChecked;// кнопка показа пароля
        public event EventHandler btnClose;//закрытие страницы
        public event EventHandler btnSendPassword;
        void NavigatetoPage(long ID);
        public void SuccessMessage(string mail);

    }
}
