using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTSC.ProfilePage.ProfileView
{
    public partial class ProfilePage : Form, IProfileView
    {
        public ProfilePage()
        {
            InitializeComponent();
            btn_back.Click += (s, e) => btnBack?.Invoke(this,EventArgs.Empty);
            btn_Close.Click += (s, e) => btnClose?.Invoke(this, EventArgs.Empty);
            btn_label.Click += (s, e) => btnToTelegram?.Invoke(this, EventArgs.Empty);
        }

        public string textMail { get => txt_mail.Text; set => txt_mail.Text=value; }
        public string textPassword { get => txt_pass.Text; set => txt_pass.Text=value; }
        public string textPasswordAgain { get => txt_pass_again.Text; set => txt_pass_again.Text=value; }

        public event EventHandler btnBack;
        public event EventHandler btnClose;
        public event EventHandler btnSave;
        public event EventHandler btnToTelegram;

        public void goBack()
        {
            this.Close();
        }
    }
}
