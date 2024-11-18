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
            btn_Ezhednevnik.Click += (s, e) => btnToEzhednevnik?.Invoke(this, EventArgs.Empty);
            btn_Generator.Click += (s, e) => btnToGenerate?.Invoke(this, EventArgs.Empty);
            btn_label.Click += (s, e) => btnToTelegram?.Invoke(this, EventArgs.Empty);
            btn_label.Links.Add(0, btn_label.Text.Length, "https://t.me/HappyBotinok_bot");
        }

        public event EventHandler btnClose;
        public event EventHandler btnToTelegram;
        public event EventHandler btnToGenerate;
        public event EventHandler btnToEzhednevnik;
        

      

        public void NavigateToEzhednevnik()
        {

        }

        public void NavigateToGenerate()
        {
            var generatorPage = new GeneratorPage.ViewGenerator.GeneratorPage();
            generatorPage.Show();
            this.Hide();
        }
    }
}
