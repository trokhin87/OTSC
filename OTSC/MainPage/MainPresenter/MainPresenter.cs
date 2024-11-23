using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OTSC.MainPage.MainModel;
using OTSC.MainPage.MainView;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Data;
namespace OTSC.MainPage.MainPresenter
{
    public class MainPresenter
    {
        private readonly IMainView _mainView;
        private long _id;
        private readonly MainModel.MainModel _model=new MainModel.MainModel();
        public MainPresenter(IMainView mainView, long ID)
        {
            _mainView = mainView;
            _mainView.btnClose += (s, e) => OnCloseBtnClick(s, e);
            _id = ID;
            _mainView.btnProfile += OnProfileBtnClick;
            _ = LoadFriendsAsync();

        }

        private async Task LoadFriendsAsync()
        {
            try
            {
                DataTable friends = await _model.GetFriedns(); // Запрос данных у модели
                if (friends != null)
                {
                    _mainView.SetFriendList(friends); // Передача данных во View
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OnProfileBtnClick(object? sender, EventArgs e)
        {
            _mainView.goToProfile(_id);
        }


       
        private void OnCloseBtnClick(object sender,EventArgs e)
        {
            if (_mainView is Form form)
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
    }
}
