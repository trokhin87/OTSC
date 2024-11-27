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
    public partial class GeneratorPage : UserControl,IChange,IGenerator
    {
        public GeneratorPage()
        {
            InitializeComponent();
            btn_add.Click += (s, e) => btnAdd?.Invoke(s, e);
            btn_delete.Click += (s, e) => btnDelete?.Invoke(this, EventArgs.Empty);
            btn_update.Click += (s, e) => btnUpdate?.Invoke(DataTableFriends, EventArgs.Empty);
            ClearBtn.Click += (s, e) => btnClear?.Invoke(this, EventArgs.Empty);
            DataTableFriends.SelectionChanged += (s, e) => cellStr?.Invoke(DataTableFriends, e);
        }

        public string friendName { get => txt_name.Text; set => txt_name.Text=value; }
        public string interested { get => txt_interes.Text; set => txt_interes.Text=value; }
        public DateTime selectedTime { get => date_picker.Value; set => date_picker.Value=value; }

        public event EventHandler btnAdd;
        public event EventHandler btnClear;
        public event EventHandler btnUpdate;
        public event EventHandler btnDelete;
        public event EventHandler cellStr;

        public void ClearLines()
        {
            txt_interes.Text=string.Empty;
            txt_name.Text=string.Empty;
            date_picker.Value=DateTime.Now;
        }

        public void SetFriendList()
        {
            throw new NotImplementedException();
        }

        public void SetFriendList(DataTable table)
        {
            DataTableFriends.DataSource = table;
        }
    }
}
