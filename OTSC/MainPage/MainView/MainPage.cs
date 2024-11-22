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
        }


        public event EventHandler btnClose;
        public event EventHandler btnToGenerate;
        public event EventHandler btnToEzhednevnik;
        public event EventHandler btnProfile;

        public void goToProfile(long id)
        {
            var profileForm = new ProfilePage.ProfileView.ProfilePage();
            var profilePresenter = new ProfilePage.ProfilePresenter.ProfilePresenter(id,profileForm);
            this.Hide();
            profileForm.ShowDialog();
            this.Show();
        }
    }
}
