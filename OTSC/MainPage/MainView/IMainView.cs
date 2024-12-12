using System.Data;


namespace OTSC.MainPage.MainView
{
    public interface IMainView
    {
        public event EventHandler btnClose;//close Page
        public event EventHandler btnToGenerate;//open Generator Table
        public event EventHandler btnToEzhednevnik;//open todo Table
        public event EventHandler btnProfile;//open profile page

        public void goToProfile(long id);// method to open profile page

        public void SetFriendList(DataTable table);//load to table database
        public void UpdateVisible();//do it visible for str true



        public event EventHandler btnAdd;
        public event EventHandler btnClear;
        public event EventHandler btnUpdate;
        public event EventHandler btnDelete;
        public string friendName { get; set; }
        public string interested { get; set; }
        public DateTime selectedTime { get; set; }
        public void ClearLines();//clear str

        public event EventHandler cellStr;//choose rows in dataTable
    }
}