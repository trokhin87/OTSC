using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTSC.MainPage.MainView
{
    public partial class MainPage : Form, IMainView
    {


        public MainPage()
        {

            InitializeComponent();
            btn_Close.Click += (s, e) => btnClose?.Invoke(this, EventArgs.Empty);
            btn_profile.Click += (s, e) => btnProfile?.Invoke(this, EventArgs.Empty);
            btn_generator.Click += (s, e) => btnToGenerate?.Invoke(this, EventArgs.Empty);
            btn_ezhednevnik.Click += (s, e) => btnToEzhednevnik?.Invoke(this, EventArgs.Empty);
            btn_add.Click += (s, e) => btnAdd?.Invoke(this, EventArgs.Empty);
            btn_delete.Click += (s, e) => btnDelete?.Invoke(this, EventArgs.Empty);
            btn_update.Click += (s, e) => btnUpdate?.Invoke(DataTableFriends, EventArgs.Empty);
            ClearBtn.Click += (s, e) => btnClear?.Invoke(this, EventArgs.Empty);
            DataTableFriends.SelectionChanged += (s, e) => cellStr?.Invoke(DataTableFriends,  e);
        }

        public string friendName { get => txt_name.Text; set => txt_name.Text=value; }
        public string interested { get => txt_interes.Text; set => txt_interes.Text=value; }
        public DateTime selectedTime { get => date_picker.Value; set => date_picker.Value=value; }

        public event EventHandler btnClose;
        public event EventHandler btnToGenerate;
        public event EventHandler btnToEzhednevnik;
        public event EventHandler btnProfile;
        public event EventHandler btnAdd;
        public event EventHandler btnClear;
        public event EventHandler btnUpdate;
        public event EventHandler btnDelete;
        public event EventHandler cellStr;


        //переход на страницу профиля
        public void goToProfile(long id)
        {
            var profileForm = new ProfilePage.ProfileView.ProfilePage();
            var profilePresenter = new ProfilePage.ProfilePresenter.ProfilePresenter(id, profileForm);
            this.Hide();
            profileForm.ShowDialog();
            this.Show();
        }

        //вывод данных в таблицу
        public void SetFriendList(DataTable table)
        {
            DataTableFriends.DataSource = table;
        }


        //Делаем видимость страницы трушной
        public void UpdateVisible()
        {
            txt_interes.Visible = true;
            txt_name.Visible = true;
            date_picker.Visible = true;
            label_data.Visible = true;
            label_interes.Visible = true;
            label_user.Visible = true;
            btn_add.Visible = true;
            btn_delete.Visible = true;
            btn_update.Visible = true;
            ClearBtn.Visible = true;
            DataTableFriends.Visible = true;
        }
        //очистка полей
        public void ClearLines()
        {
            txt_interes.Text=string.Empty;
            txt_name.Text=string.Empty;
            date_picker.Value=DateTime.Now;
        }
    }
}
