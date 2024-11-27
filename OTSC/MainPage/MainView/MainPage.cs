using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OTSC.MainPage.MainView
{
    public partial class MainPage : Form, IMainView
    {


        public MainPage()
        { 
            InitializeComponent();
            btn_Close.Click += (s, e) => btnClose?.Invoke(this, EventArgs.Empty);
            btn_profile.Click += (s, e) => btnProfile?.Invoke(this, EventArgs.Empty);
            btn_ezhednevnik.Click += (s, e) => btnEzhednevnik?.Invoke(this, EventArgs.Empty);
            btn_generator.Click += (s, e) => btnGenerator?.Invoke(this, EventArgs.Empty);
        }


        public event EventHandler btnClose;
        public event EventHandler btnProfile;
        public event EventHandler btnEzhednevnik;
        public event EventHandler btnGenerator;




        //переход на страницу профиля
        public void goToProfile(long id)
        {
            var profileForm = new ProfilePage.ProfileView.ProfilePage();
            var profilePresenter = new ProfilePage.ProfilePresenter.ProfilePresenter(id, profileForm);
            this.Hide();
            profileForm.ShowDialog();
            this.Show();
        }

        
        public void LoadPage(UserControl page)
        {
            mainPanel.Controls.Clear(); // Очищаем панель
            page.Dock = DockStyle.Fill;      // Устанавливаем растяжение на всю панель
            mainPanel.Controls.Add(page);
        }

        
    }
}
