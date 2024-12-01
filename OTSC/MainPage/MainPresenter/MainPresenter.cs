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
        private readonly IChange _change;
        private readonly IGenerator _generator;
        public MainPresenter(IMainView mainView, long ID,IChange change,IGenerator generator)
        {
            _mainView = mainView;
            _change = change;
            _generator = generator;
            _mainView.btnClose += (s, e) => OnCloseBtnClick(s, e);
            _id = ID;
            _mainView.btnProfile += OnProfileBtnClick;
            _mainView.btnEzhednevnik += OnEzhednevnikBtnClick;
            _mainView.btnGenerator += OnGeneratorBtnClick;
            _mainView.btnGenerator +=async(s,e) => LoadFriendsAsync(s,e);

            _generator.cellStr += OnCellBtnClicked;
            _change.cellStr += OnCellBtnClicked;
            _change.btnAdd += OnAddBtnClicked;
            _change.btnUpdate += OnUpdateBtnClicked;
            _change.btnDelete += OnDeleteBtnClicked;
            _change.btnClear += OnClearBtnClickes;

        }

        private void OnClearBtnClickes(object? sender, EventArgs e)
        {
            _change.ClearLines();
        }

        private void OnCellBtnClicked(object? sender, EventArgs e)
        {
            // Проверяем, что sender — это DataGridView
            if (sender is DataGridView dataGridView && dataGridView.CurrentRow != null)
            {
                // Получаем данные из текущей строки
                var selectedRow = dataGridView.CurrentRow;
                if (selectedRow.Cells["friend_username"].Value != null)
                {
                    _generator.friendName = selectedRow.Cells["friend_username"].Value.ToString();
                }

                if (selectedRow.Cells["date_of_birth"].Value != null)
                {
                    _generator.selectedTime = Convert.ToDateTime(selectedRow.Cells["date_of_birth"].Value);
                }

                if (selectedRow.Cells["interested"].Value != null)
                {
                    _generator.interested = selectedRow.Cells["interested"].Value.ToString();
                }
            }
        }
        private async Task LoadFriendsAsync(object sender, EventArgs e)
        {
            try
            {
                DataTable friends = await _model.GetFriedns(_id); // Запрос данных у модели
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void OnAddBtnClicked(object? sender, EventArgs e)
        {
            if (_generator.interested == string.Empty || _generator.friendName == string.Empty)
            {
                MessageBox.Show("Введите данные о друге", "Ошибка заполнения данных", MessageBoxButtons.OK);
            }
            bool isCool = await _model.AddFriendAsync(_id, _generator.friendName, _generator.selectedTime, _generator.interested);
            if (isCool)
            {
                await LoadFriendsAsync(sender, e);
            }
        }
        private async void OnUpdateBtnClicked(object? sender, EventArgs e)
        {
            if (_generator.interested == string.Empty || _generator.friendName == string.Empty)
            {
                MessageBox.Show("Введите данные о друге", "Ошибка заполнения данных", MessageBoxButtons.OK);
            }
            string choose = null;
            if (sender is DataGridView dataGridView && dataGridView.CurrentRow != null)
            {
                // Получаем данные из текущей строки
                var selectedRow = dataGridView.CurrentRow;
                if (selectedRow.Cells["friend_username"].Value != null)
                {
                    choose = selectedRow.Cells["friend_username"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Не удалось обновление");
                    return;
                }

                bool isCool = await _model.UpdateFriendAsync(_id, _generator.friendName, _generator.selectedTime, _generator.interested, choose);
                if (isCool)
                {

                    await LoadFriendsAsync(sender, e);
                }
            }
        }
        private async void OnDeleteBtnClicked(object? sender, EventArgs e)
        {
            if (_generator.interested == string.Empty || _generator.friendName == string.Empty)
            {
                MessageBox.Show("Введите данные о друге", "Ошибка заполнения данных", MessageBoxButtons.OK);
            }
            bool isCool = await _model.DeleteFriendAsync(_id, _generator.friendName);
            if (isCool)
            {
                await LoadFriendsAsync(sender, e);
            }
        }






















        private readonly GeneratorPage generatorPage = new GeneratorPage();

        private void OnGeneratorBtnClick(object? sender, EventArgs e)
        {
            _mainView.LoadPage(generatorPage);
        }

        private void OnEzhednevnikBtnClick(object? sender, EventArgs e)
        {
            _mainView.LoadPage(new ToDoPage());
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
