using System;
using System.Windows;
using System.Windows.Shapes;
using System.Xml;
using System.Security.Cryptography;

namespace License
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Name, Path = @"C:\Users\user\Downloads\StudentCard\StudentCardApp\WpfApplication1\bin\Debug"; //путь сохранения файла лицензии
            DateTime StartDate, End;
            Name = textBox_FIO.Text;
            StartDate = Convert.ToDateTime(DatePicker_Start.SelectedDate);
            End = Convert.ToDateTime(DatePicker_End.SelectedDate);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(@" <license>
            <Name></Name>
            <Date></Date>
            <UpdateTo></UpdateTo>
            <Signature></Signature>
            </license>");
                doc.ChildNodes[0].SelectSingleNode(@"/license/Name", null).InnerText = Name;
                doc.ChildNodes[0].SelectSingleNode(@"/license/Date", null).InnerText = StartDate.ToShortDateString();
                doc.ChildNodes[0].SelectSingleNode(@"/license/UpdateTo", null).InnerText = End.ToShortDateString();

                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] data = System.Text.Encoding.UTF8.GetBytes(Name + StartDate.ToShortDateString() + End.ToShortDateString() + "SomePasswordKey");
                byte[] hash = md5.ComputeHash(data);
                doc.ChildNodes[0].SelectSingleNode(@"/license/Signature", null).InnerText = Convert.ToBase64String(hash);
                doc.Save(System.IO.Path.Combine(Path, "license.xml"));
            MessageBox.Show("Лизензия для приложения " + Name + " сохранена в " + Path + "\nИ будет действовать с " + StartDate + " до " + End);
        }

    }
}
