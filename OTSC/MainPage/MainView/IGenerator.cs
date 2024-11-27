using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC.MainPage.MainView
{
    public interface IGenerator
    {
        public void SetFriendList(DataTable table);//load to table database
        public string friendName { get; set; }
        public string interested { get; set; }
        public DateTime selectedTime { get; set; }

        public event EventHandler cellStr;//choose rows in dataTable
    }
}
