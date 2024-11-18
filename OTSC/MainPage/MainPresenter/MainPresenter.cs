using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OTSC.MainPage.MainModel;
using OTSC.MainPage.MainView;
using System.Diagnostics;
namespace OTSC.MainPage.MainPresenter
{
    public class MainPresenter
    {
        private readonly IMainView _mainView;
        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;
            _mainView.btnClose += (s, e) => OnCloseBtnClick(s, e);
            _mainView.btnToTelegram += OnTelegramBtnClick;
            _mainView.btnToEzhednevnik += OnEzhednevnikBtnClick;
            _mainView.btnToGenerate += OnGeneratorBtnClick;

        }

        private void OnGeneratorBtnClick(object? sender, EventArgs e)
        {
            _mainView.NavigateToGenerate();
        }

        private void OnEzhednevnikBtnClick(object? sender, EventArgs e)
        {
            _mainView.NavigateToEzhednevnik();
        }

        private void OnTelegramBtnClick(object? sender, EventArgs e)
        {
            try
            {
                Process.Start( new ProcessStartInfo
                {
                    FileName= "https://t.me/HappyBotinok_bot",
                    UseShellExecute = true,
                }
                ) ;
            }
            catch
            {
                MessageBox.Show("Не удалось открыть ссылку, попробуйте QR-код", "Ошибка открытия", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
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
