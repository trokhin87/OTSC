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



            _mainView.btnToGenerate +=(s,e) =>LoadFriendsAsync(s,e);
            _mainView.btnClear += OnClearBtnClicked;
            _mainView.cellStr += OnCellBtnClicked;
            _mainView.btnAdd += OnAddBtnClicked;
            _mainView.btnUpdate += OnUpdateBtnClicked;
            _mainView.btnDelete += OnDeleteBtnClicked;
        }

        private async void OnDeleteBtnClicked(object? sender, EventArgs e)
        {
            if (_mainView.interested == string.Empty || _mainView.friendName == string.Empty)
            {
                MessageBox.Show("Введите данные о друге", "Ошибка заполнения данных", MessageBoxButtons.OK);
            }
            bool isCool = await _model.DeleteFriendAsync(_id, _mainView.friendName, _mainView.selectedTime, _mainView.interested);
            if (isCool)
            {
                await LoadFriendsAsync(sender, e);
            }
        }

        private void OnUpdateBtnClicked(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void OnAddBtnClicked(object? sender, EventArgs e)
        {
            if (_mainView.interested == string.Empty || _mainView.friendName == string.Empty)
            {
                MessageBox.Show("Введите данные о друге","Ошибка заполнения данных",MessageBoxButtons.OK);
            }
            bool isCool = await _model.AddFriendAsync(_id, _mainView.friendName, _mainView.selectedTime, _mainView.interested);
            if (isCool)
            {
                await LoadFriendsAsync(sender, e);
            }
        }


        //выбор колонки из dataTable
        private void OnCellBtnClicked(object? sender, EventArgs e)
        {
            // Проверяем, что sender — это DataGridView
            if (sender is DataGridView dataGridView && dataGridView.CurrentRow != null)
            {
                // Получаем данные из текущей строки
                var selectedRow = dataGridView.CurrentRow;
                if (selectedRow.Cells["friend_username"].Value != null)
                {
                    _mainView.friendName = selectedRow.Cells["friend_username"].Value.ToString();
                }

                if (selectedRow.Cells["date_of_birth"].Value != null)
                {
                    _mainView.selectedTime = Convert.ToDateTime(selectedRow.Cells["date_of_birth"].Value);
                }

                if (selectedRow.Cells["interested"].Value != null)
                {
                    _mainView.interested = selectedRow.Cells["interested"].Value.ToString();
                }
            }
        }




        //нажатие кнопки очистки
        private void OnClearBtnClicked(object? sender, EventArgs e)
        {
            _mainView.ClearLines();
        }


        //подсос данных из бд
        private async Task LoadFriendsAsync(object sender,EventArgs e)
        {
            _mainView.UpdateVisible();
            try
            {
                DataTable friends = await _model.GetFriedns(_id); // Запрос данных у модели
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






        //открытие страницы профиля
        private void OnProfileBtnClick(object? sender, EventArgs e)
        {
            _mainView.goToProfile(_id);
        }


       //закрытие приложения
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
