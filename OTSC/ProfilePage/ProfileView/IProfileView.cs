using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC.ProfilePage.ProfileView
{
    public interface IProfileView
    {
        public event EventHandler btnBack;
        public event EventHandler btnClose;
        public string textMail { get; set; }
        public string textPassword { get; set; }
        public string textPasswordAgain { get; set; }
        public event EventHandler btnSavePass;
        public event EventHandler btnToTelegram;
        public event EventHandler btnSaveMail;

        public void goBack();
        public void openLink();
    }
}
