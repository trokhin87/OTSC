using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OTSC.MainPage.MainModel;
using OTSC.MainPage.MainView;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Data;
namespace OTSC.MainPage.MainPresenter
{
    public class MainPresenter
    {
        private readonly IMainView _mainView;
        private long _id;
        private readonly MainModel.MainModel _model=new MainModel.MainModel();
        private readonly IChange _change;
        private readonly IGenerator _generator;
        public MainPresenter(IMainView mainView, long ID,IChange change,IGenerator generator)
        {
            _mainView = mainView;
            _change = change;
            _generator = generator;
            _mainView.btnClose += (s, e) => OnCloseBtnClick(s, e);
            _id = ID;
            _mainView.btnProfile += OnProfileBtnClick;
            _mainView.btnEzhednevnik += OnEzhednevnikBtnClick;
            _mainView.btnGenerator += OnGeneratorBtnClick;

        }

        private void OnGeneratorBtnClick(object? sender, EventArgs e)
        {
            _mainView.LoadPage(new GeneratorPage());
        }

        private void OnEzhednevnikBtnClick(object? sender, EventArgs e)
        {
            _mainView.LoadPage(new ToDoPage());
        }

        //открытие страницы профиля
        private void OnProfileBtnClick(object? sender, EventArgs e)
        {
            _mainView.goToProfile(_id);
        }


       //закрытие приложения
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
