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

namespace hackr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            string language = languageComboBox.SelectedItem.ToString();
          /* string language = e.AddedItems[0].ToString();
           
            switch(language)
            {
                case "C":
                    break;
                case "C++":
                    break;
                case "C#":
                    break;
                case "Java":
                    break;
                case "JavaScript":
                    break;
                case "Python":
                    break;
                case "Ruby":
                    break;
                case "Swift":
                    break;
                case "Go":
                    break;
            }*/
            //store value in actual csv file
            Console.WriteLine(language);
        }


        private void Years_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double ExperienceValue = years.Value;
            Console.WriteLine(ExperienceValue);
        }

        private void GradeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string grade = gradeComboBox.SelectedItem.ToString();
            Console.WriteLine(grade);
        }


        private void LearnComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string learn = learnComboBox.SelectedItem.ToString();
            Console.WriteLine(learn);
        }

        private void TeachComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string teach = teachComboBox.SelectedItem.ToString();
            Console.WriteLine(teach);
        }
    }
}
