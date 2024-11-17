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
    public partial class MainPage : Form,IMainView
    {
        private bool _theme;
        public MainPage(bool theme)
        {
            _theme = theme;
            InitializeComponent();
            btn_Close.Click += (s, e) => btnClose?.Invoke(this, EventArgs.Empty);
            pic_Theme.Click += (s, e) => btnTheme?.Invoke(this, _theme);
            btn_Ezhednevnik.Click += (s, e) => btnToEzhednevnik?.Invoke(this, EventArgs.Empty);
            btn_Generator.Click += (s, e) => btnToGenerate?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler btnClose;
        public event EventHandler btnToTelegram;
        public event EventHandler btnToGenerate;
        public event EventHandler btnToEzhednevnik;
        public event EventHandler<bool> btnTheme;

        public void NavigateToEzhednevnik()
        {
           
        }

        public void NavigateToGenerate()
        {
            
        }
    }
}
