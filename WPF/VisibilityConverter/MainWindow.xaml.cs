using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace VisibilityConverter {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Resources["ButtonBrushKey"] = new SolidColorBrush(Colors.Black);
        }

        private ColorViewModel[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new ColorViewModel() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void CombBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var c = ((ColorViewModel)(((ComboBox)sender).SelectedItem)).Color;
            btColor.Background = new SolidColorBrush(c);
        }
    }
}
