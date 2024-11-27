using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OTSC.MainPage.MainView;

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
            btn_Close.Click += (s, e) => btnClose?.Invoke(this, EventArgs.Empty);
            label_mail.Click += (s, e) => btnSendPassword?.Invoke(this, EventArgs.Empty);



            txtPassword.PasswordChar = '*';
        }
        public event EventHandler btnRegister;
        public event EventHandler btnClear;
        public event EventHandler btnChecked;
        public event EventHandler btnLogin;
        public event EventHandler btnClose;
        public event EventHandler btnSendPassword;

        public void NavigatetoPage(long ID)
        {
            var mainPage=new MainPage.MainView.MainPage();
            var generator = new GeneratorPage();
            var presenterMain = new MainPage.MainPresenter.MainPresenter(mainPage,ID,generator,generator);
            mainPage.Show();
            this.Hide();
        }
        public void SuccessMessage(string mail)
        {
            label_info.Text =$"Новый пароль отправлен на почту: {mail}"; 
            label_info.Visible = true;
        }

    }
}
