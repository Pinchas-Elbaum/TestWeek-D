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
                "�����" => "���� ����",
                "���" => "���� ����",
                "�����" => "������ ����",
                "�����" => "������ ����",
                "�����" => "������ ����",
                "����" => "���� ����",
                null => "",
            };
            return day;
        }
        public string GetCorrectDayAtMonth()
        {
            string dayAtMonth = DatAtMonth_cmb.Text switch
            {
                "1" => "��� ��� ����",
                "2" => "��� ���� ����",
                "3" => "���� ���� ����",
                "4" => "����� ���� ����",
                "5" => "���� ���� ����",
                "6" => "��� ���� ����",
                "7" => "���� ���� ����",
                "8" => "���� ���� ����",
                "9" => "���� ���� ����",
                "10" => "���� ���� ����",
                "11" => "��� ��� ��� ����",
                "12" => "���� ��� ��� ����",
                "13" => "���� ��� ��� ����",
                "14" => "����� ��� ��� ����",
                "15" => "���� ��� ��� ����",
                "16" => "��� ��� ��� ����",
                "17" => "���� ��� ��� ����",
                "18" => "���� ��� ��� ����",
                "19" => "���� ��� ��� ����",
                "20" => "����� ��� ����",
                "21" => "��� ������ ��� ����",
                "22" => "���� ������ ��� ����",
                "23" => "���� ������ ��� ����",
                "24" => "����� ������ ��� ����",
                "25" => "���� ������ ��� ����",
                "26" => "��� ������ ��� ����",
                "27" => "���� ������ ��� ����",
                "28" => "���� ������ ��� ����",
                "29" => "���� ������ ��� ����",
                "30" => $"���� ��� ���� ��� ���� ���� {GetCorrectYear} ��� ������ ����� ",
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
                "���''�" => "���� ����� ����� �����",
                "���''�" => "���� ����� ����� ����",
                "���''�" => "���� ����� ����� ���",
                "���''�" => "���� ����� ����� ����",
                "���''�" => "���� ����� ����� �����",
                "���''�" => "���� ����� ����� ����",
                "��''�" => "���� ����� ������",
                null => "",
            };
            return year;
        }
        











    }
}
