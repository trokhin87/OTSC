using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC.MainPage.MainView
{
    public interface IChange
    {
        public event EventHandler btnAdd;
        public event EventHandler btnClear;
        public event EventHandler btnUpdate;
        public event EventHandler btnDelete;
        public void ClearLines();//clear str


        public void SetFriendList();
        public event EventHandler cellStr;
    }
}
