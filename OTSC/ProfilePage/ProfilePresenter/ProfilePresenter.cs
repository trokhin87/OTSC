using OTSC.MainPage.MainView;
using OTSC.ProfilePage.ProfileModel;
using OTSC.ProfilePage.ProfileView;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OTSC.ProfilePage.ProfilePresenter
{
    public class ProfilePresenter
    {
        private long _id;
        private readonly IProfileView _profileView;
        private readonly ProfileModel.ProfileModel _profileModel=new ProfileModel.ProfileModel();
        public ProfilePresenter(long ID,IProfileView view) 
        {
            _id = ID;
            _profileView = view;
            _profileView.btnToTelegram +=(s,e)=> OnLinkBtnClicked(s,e);
            _profileView.btnBack += (s, e) => OnBackBtnClicked(s,e);
            _profileView.btnClose += (s, e) => OnCloseBtnClicked(s, e);
            _profileView.btnSaveMail += OnMailBtnClick;
            _profileView.btnSavePass += OnPasswordBtnClick;
        }

        private async void OnMailBtnClick(object? sender, EventArgs e)
        {
            var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            var regex = new Regex(emailPattern);
            if (regex.IsMatch(_profileView.textMail))
            {
                bool isGood = await _profileModel.IsSend(_id, _profileView.textMail);
                if (isGood)
                {
                    MessageBox.Show("Почта успешно сохранена", "Успех", MessageBoxButtons.OK);
                }
            }
            else MessageBox.Show("Введены некоректные данные почты", "Неудача", MessageBoxButtons.OK);
        }

        private void OnLinkBtnClicked(object sender,EventArgs e)
        {
            _profileView.openLink();
        }
        private void OnBackBtnClicked(object sender,EventArgs e)
        {
            _profileView.goBack();
        }
        private void OnCloseBtnClicked(object sender,EventArgs e)
        {
            if (_profileView is Form form)
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
        private async void OnPasswordBtnClick(object? sender,EventArgs e)
        {
            
            if (_profileView.textPassword == string.Empty || _profileView.textPasswordAgain == string.Empty)
            {
                MessageBox.Show("Введите данные","Неккоректный ввод",MessageBoxButtons.OK);
            }
            bool isgood = await _profileModel.RewritePass(_id, _profileView.textPassword, _profileView.textPasswordAgain);
            if (isgood)
            {
                MessageBox.Show("Пароль успешно изменен", "Успех", MessageBoxButtons.OK);
            }
        }
    }
}
