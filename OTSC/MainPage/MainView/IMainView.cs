using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC.MainPage.MainView
{
    public interface IMainView
    {
        public event EventHandler btnClose;//close Page
        public event EventHandler btnProfile;//open profile page

        public void goToProfile(long id);// method to open profile page
        public event EventHandler btnEzhednevnik;
        public event EventHandler btnGenerator;
        public void LoadPage(UserControl page);
    }
}