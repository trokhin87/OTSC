using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTSC.LoginPage.LoginView
{
    public partial class LoginPage : Form, ILogin
    {
        public string Login { get => txtLogin.Text; set => txtLogin.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public char PasswordChar { get => txtPassword.PasswordChar; set => txtPassword.PasswordChar = value; }
        public bool isCheckedPass { get => btn_showPass.Checked; set => btn_showPass.Checked = value; }
        public LoginPage()
        {
            InitializeComponent();
            btn_Login.Click += (s, e) => btnLogin?.Invoke(this, EventArgs.Empty);
            btn_Register.Click += (s, e) => btnRegister?.Invoke(this, EventArgs.Empty);
            btn_showPass.CheckedChanged += (s, e) => btnChecked?.Invoke(this, EventArgs.Empty);
            clear_Button.Click += (s, e) => btnClear?.Invoke(this, EventArgs.Empty);
            pic_Theme.Click += (s, e) => btnTheme?.Invoke(this, EventArgs.Empty);
            btn_Close.Click += (s, e) => btnClose?.Invoke(this, EventArgs.Empty);



            txtPassword.PasswordChar = '*';
        }
        public event EventHandler btnRegister;
        public event EventHandler btnClear;
        public event EventHandler btnChecked;
        public event EventHandler btnTheme;
        public event EventHandler btnLogin;
        public event EventHandler btnClose;

        public void NavigatetoPage(bool theme)
        {
            var mainPage=new MainPage(theme);
            mainPage.Show();
            this.Hide();
        }
    }
}
