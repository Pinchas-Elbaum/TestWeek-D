using System.Windows.Forms;
using static Test_Week_D.Service.CorrectDateService;
namespace Test_Week_D
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CreatXmlIfNotExist();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GetCorrectDate_btn(object sender, EventArgs e)
        {
            string Day = GetCorrectDay();
            string DayMonth = GetCorrectDayAtMonth();
            string Month = GetCorrectMonth();
            string Year = GetCorrectYear();
            MessageBox.Show($"{Day} {DayMonth} {Month} {Year}");
            
            AddQuery(Day, DayMonth, Month, Year);
        }
        public string GetCorrectDay()
        {
            string day = Day_cmb.Text switch
            {
                "øàùåï" => "áàçã áùáú",
                "ùğé" => "áùğé áùáú",
                "ùìéùé" => "áùìéùé áùáú",
                "øáéòé" => "áøáéòé áùáú",
                "çîéùé" => "áçîéùé áùáú",
                "ùéùé" => "áùùé áùáú",
                null => "",
            };
            return day;
        }
        public string GetCorrectDayAtMonth()
        {
            string dayAtMonth = DatAtMonth_cmb.Text switch
            {
                "1" => "éåí àçã ìéøç",
                "2" => "ùğé éîéí ìéøç",
                "3" => "ùìùä éîéí ìéøç",
                "4" => "àøáòä éîéí ìéøç",
                "5" => "çîùä éîéí ìéøç",
                "6" => "ùùä éîéí ìéøç",
                "7" => "ùáòä éîéí ìéøç",
                "8" => "ùîğä éîéí ìéøç",
                "9" => "úùòä éîéí ìéøç",
                "10" => "òùøä éîéí ìéøç",
                "11" => "àçã òùø éåí ìéøç",
                "12" => "ùğéí òùø éåí ìéøç",
                "13" => "ùìùä òùø éåí ìéøç",
                "14" => "àøáòä òùø éåí ìéøç",
                "15" => "çîùä òùø éåí ìéøç",
                "16" => "ùùä òùø éåí ìéøç",
                "17" => "ùáòä òùø éåí ìéøç",
                "18" => "ùîğä òùø éåí ìéøç",
                "19" => "úùòä òùø éåí ìéøç",
                "20" => "òùøéí éåí ìéøç",
                "21" => "àçã åòùøéí éåí ìéøç",
                "22" => "ùğéí åòùøéí éåí ìéøç",
                "23" => "ùìùä åòùøéí éåí ìéøç",
                "24" => "àøáòä åòùøéí éåí ìéøç",
                "25" => "çîùä åòùøéí éåí ìéøç",
                "26" => "ùùä åòùøéí éåí ìéøç",
                "27" => "ùáòä åòùøéí éåí ìéøç",
                "28" => "ùîğä åòùøéí éåí ìéøç",
                "29" => "úùòä åòùøéí éåí ìéøç",
                "30" => $"ùäåà øàù çåãù äáà àçøé çåãù {GetCorrectYear} éåí ùìåùéí ìçåãù ",
                null => "",
            };

            return dayAtMonth;
        }
        public string GetCorrectMonth()
        {
            string month = Month_cmb.Text;
            return month;
        }
        public string GetCorrectYear()
        {
            string year = Year_cmb.Text switch
            {
                "úùô''ã" => "çîùú àìôéí ùîğéí åàøáò",
                "úùô''ä" => "çîùú àìôéí ùîğéí åçîù",
                "úùô''å" => "çîùú àìôéí ùîğéí åùù",
                "úùô''æ" => "çîùú àìôéí ùîğéí åùáò",
                "úùô''ç" => "çîùú àìôéí ùîğéí åùîğä",
                "úùô''è" => "çîùú àìôéí ùîğéí åúùò",
                "úù''ö" => "çîùú àìôéí åúùòéí",
                null => "",
            };
            return year;
        }
        











    }
}
