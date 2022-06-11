using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _11._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Гребенюк А., 21-ИСП-2, 3-я лабораторная, средний уровень, 2-й вариант
        DateTime date1;
        Employee employee = new Employee();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Accept_Click(object sender, RoutedEventArgs e)
        {
            date1 = new DateTime(employee.year, employee.month, employee.day);
            Output.Text = employee.NameSurname + ", Employment: " + date1.ToString("d");
            YearsOnDuty.Text = "Years on duty: " + employee.YearsInActions(employee.year);
        }
        private void TextDays_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextDay.Text != "")
                employee.day = Convert.ToInt32(TextDay.Text);
        }
        private void TextMonth_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextMonth.Text != "")
                employee.month = Convert.ToInt32(TextMonth.Text);
        }
        private void TextYears_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextYear.Text != "")
                employee.year = Convert.ToInt32(TextYear.Text);
        }

        private void InputName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (InputName.Text != "")
                employee.NameSurname = InputName.Text;
        }
    }
}
