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
        public event EventHandler btnClose;
        public event EventHandler btnToGenerate;
        public event EventHandler btnToEzhednevnik;
        public event EventHandler btnProfile;

        public void goToProfile(long id);

        public void SetFriendList(DataTable table);
        public void UpdateVisible();



        public event EventHandler btnAdd;
        public event EventHandler btnClear;
        public event EventHandler btnUpdate;
        public event EventHandler btnDelete;
        public string friendName { get; set; }
        public string interested { get; set; }
        public DateTime selectedTime { get; set; }

    }
}