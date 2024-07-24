using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Test_Week_D.Configuration.Configuration;

namespace Test_Week_D.Service
{
    internal static class CorrectDateService
    {
        public static void CreatXmlIfNotExist()
        {
            if (!File.Exists(CorrectDatePath))
            {
                XDocument document = new();// יצירת קובץ חדש
                XElement correctDat = new("Queries");// יצירת אלמנט
                document.Add(correctDat); // הוספת אלמנט לקובץ
                document.Save(CorrectDatePath); // שמירה לנתיב המתאים
            }
        }
        public static void AddQuery(string day, string dayAtMonth, string month, string year)
        {
            XDocument document = XDocument.Load(CorrectDatePath);
            XElement? Queries = document.Descendants("Queries").FirstOrDefault();
            if (Queries == null)
            {
                return;
            }
            XElement Query = new("Query", new XAttribute( ("Day", day),("DayAtMonth", DayAtMonth)));          
            XElement DayAtMonth = new(dayAtMonth);
            XElement Month = new(month);
            XElement Year = new(year);
            Queries.Add(Query);           
            document.Save(CorrectDatePath);
        }
    }
}
//שאלות
//שאלה
//יום
//יום בחודש
//חודש
//שנה
//תןצאה
