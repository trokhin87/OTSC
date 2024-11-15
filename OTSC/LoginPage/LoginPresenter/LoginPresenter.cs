using OTSC.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OTSC.LoginPage.LoginView;
using OTSC.LoginPage.LoginModel;

namespace OTSC.LoginPage.LoginPresenter
{
    public class LoginPresenter
    {
        private readonly LoginModel.LoginModel _model;
        private readonly ILogin _view;
        private bool _isLight = true;
        public LoginPresenter(ILogin view)
        {
            _view = view;
            _model = new LoginModel.LoginModel();


            _view.btnClear += (s, e) => OnClearBtnClicked(s, e);
            _view.btnTheme += (s, e) => OnThemeBtnClicked(s, e);
            _view.btnClose += (s, e) => OnCloseBtnClicked(s, e);
            _view.btnChecked += (s, e) => OnShowBtnChecekd(s, e);

            _view.btnLogin += (s, e) => OnLoginBtnClicked(s, e);
            _view.btnRegister += (s, e) => OnRegisterBtnChecked(s, e);
        }
        private void OnShowBtnChecekd(object sender,EventArgs e)
        {
            if (_view.isCheckedPass)
            {
                _view.PasswordChar = '\0';
            }
            else _view.PasswordChar = '*';
        }
        private void OnClearBtnClicked(object sender, EventArgs e)
        {
            _view.Login = string.Empty;
            _view.Password = string.Empty;
        }
        private void OnThemeBtnClicked(object sender, EventArgs e)
        {
            if (_view is Form form)
            {
                if (_isLight)
                {
                    form.BackColor = Color.DimGray;
                    _isLight = false;
                }
                else
                {
                    _isLight = true;
                    form.BackColor = Color.LightGray;
                }

            }
        }
        private void OnCloseBtnClicked(object sender, EventArgs e)
        {
            if (_view is Form form)
            {
                var result = MessageBox.Show
                    (
                        "Вы уверены, что хотите выйти из приложения?",
                        "Подтверждение закрытия",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes) { Application.Exit(); }

            }

        }
        private void OnLoginBtnClicked(object sender,EventArgs e)
        {
            //if (_view.Login == string.Empty || _view.Password == string.Empty)
            //{
            //    MessageBox.Show("строка ID или пароля пусты", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
            if(!long.TryParse(_view.Login,out long ID)|| _view.Login == string.Empty || _view.Password == string.Empty)
            {
                MessageBox.Show("Введите корректные данные","Ошибка ввода",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }
        private void OnRegisterBtnChecked(object sender,EventArgs e)
        {
            //if (_view.Login == string.Empty || _view.Password == string.Empty)
            //{
            //    MessageBox.Show("строка ID или пароля пусты","Ошибка ввода",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            //}
            if (!long.TryParse(_view.Login, out long ID)|| _view.Login == string.Empty || _view.Password == string.Empty)
            {
                MessageBox.Show("Введите корректные данные", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }
    }
}
