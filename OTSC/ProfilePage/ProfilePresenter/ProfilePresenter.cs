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

namespace OTSC.ProfilePage.ProfilePresenter
{
    public class ProfilePresenter
    {
        private long _id;
        private readonly IProfileView _profileView;
        private readonly ProfileModel.ProfileModel _profileModel;
        public ProfilePresenter(long ID) 
        {
            _id = ID;

        }
        //private async void onSendMailCLick(object? sender, EventArgs e)
        //{
        //    string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        //    if (_mainView.mail == string.Empty)
        //    {
        //        MessageBox.Show("Заполните поле, подтверждающие почту", "Ошибка записи", MessageBoxButtons.OK, MessageBoxIcon.None);
        //    }
        //    if (Regex.IsMatch(_mainView.mail, emailPattern))
        //    {
        //        bool cool = await _model.IsSend(_id, _mainView.mail);
        //        if (cool)
        //        {
        //            MessageBox.Show("Успешно сохраненно", "Успех");
        //            _mainView.DropVisible();
        //        }

        //    }
        //}
        //private void OnTelegramBtnClick(object? sender, EventArgs e)
        //{
        //    try
        //    {
        //        Process.Start(new ProcessStartInfo
        //        {
        //            FileName = "https://t.me/HappyBotinok_bot",
        //            UseShellExecute = true,
        //        }
        //        );
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Не удалось открыть ссылку, попробуйте QR-код", "Ошибка открытия", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
