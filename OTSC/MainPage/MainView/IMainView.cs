using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC.MainPage.MainView
{
    public interface IMainView
    {
        public event EventHandler btnClose;
        public event EventHandler btnToTelegram;
        public event EventHandler btnToGenerate;
        public event EventHandler btnToEzhednevnik;
        public event EventHandler<bool> btnTheme;
        public void NavigateToGenerate();
        public void NavigateToEzhednevnik();
    }
}
